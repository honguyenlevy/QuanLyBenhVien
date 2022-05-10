CREATE TABLE KUNV
(
U VARCHAR2(7) PRIMARY KEY,
K RAW(2000)
)


CREATE OR REPLACE PROCEDURE TaoKhoaNV
AS
    keyRaw raw(32);
    CURSOR CUR IS SELECT MANV FROM NHANVIEN;
    V_MANV VARCHAR2(7);
BEGIN
   OPEN CUR;
   LOOP 
     FETCH CUR INTO V_MANV;
    EXIT WHEN CUR%NOTFOUND;
    keyRaw := DBMS_CRYPTO.RANDOMBYTES (32);
    INSERT INTO KUNV VALUES(UPPER(V_MANV),UTL_RAW.BIT_XOR(keyRaw, UTL_I18N.STRING_TO_RAW(TRIM(UPPER(V_MANV)))));
    END LOOP;
END;

insert into nhanvien(manv,hoten,cmnd) values ('nv1','Linh','334957777');
EXEC TAOKHOANV;





--T?O H�M M� H�A
CREATE OR REPLACE FUNCTION ENCRYPT(plainText in varchar2, keyRaw in raw )
RETURN raw
IS
      encryption_type    PLS_INTEGER :=  DBMS_CRYPTO.ENCRYPT_AES256 + DBMS_CRYPTO.CHAIN_CBC + DBMS_CRYPTO.PAD_PKCS5;
      iv_raw             RAW (16);
      cipherText raw(2000);
BEGIN
   iv_raw        := DBMS_CRYPTO.RANDOMBYTES (16);
   cipherText := DBMS_CRYPTO.ENCRYPT
      (
         src => UTL_I18N.STRING_TO_RAW (plainText,  'AL32UTF8'),
         typ => encryption_type,
         key => keyRaw,
         iv  => iv_raw
      );
    cipherText := UTL_RAW.CONCAT(iv_raw, cipherText);
    RETURN cipherText;
END ENCRYPT;
/
show errors
/

--H�M GI?I M�
CREATE OR REPLACE FUNCTION DECRYPT(cipherText in raw, keyRaw in raw)
RETURN varchar2
IS
     encryption_type    PLS_INTEGER :=  DBMS_CRYPTO.ENCRYPT_AES256 + DBMS_CRYPTO.CHAIN_CBC + DBMS_CRYPTO.PAD_PKCS5;
    plainText varchar2(200);
     decrypted_raw raw(2000);
     iv_raw             RAW (16);
     cipher             RAW(2000);
BEGIN
    IF (cipherText is not null) THEN
       iv_raw := UTL_RAW.SUBSTR(cipherText, 0,  16);
       cipher:= UTL_RAW.SUBSTR(cipherText, 17,  UTL_RAW.LENGTH( cipherText) - 16);
       decrypted_raw := DBMS_CRYPTO.DECRYPT
      (
         src => cipher,
         typ => encryption_type,
         key => keyRaw,
         iv  => iv_raw
      );
      plainText  := UTL_I18N.RAW_TO_CHAR (decrypted_raw, 'AL32UTF8');
    ELSE
      plainText   := null;
    END IF;
  
  RETURN  plainText;
END;


ALTER TABLE NHANVIEN
ADD CMND_ENCRYPT RAW(2000);




CREATE OR REPLACE PROCEDURE MaHoaNV

AS
    keyModified raw(2000);
    CURSOR CUR IS SELECT MANV FROM NHANVIEN;
    V_MANV VARCHAR2(7);
    V_CMND VARCHAR2(20);
BEGIN
  
OPEN CUR;
   LOOP 
     FETCH CUR INTO V_MANV;
     EXIT WHEN CUR%NOTFOUND;
     
      select  K into keyModified from KUNV WHERE TRIM(UPPER(U))=TRIM(UPPER(V_MANV));
       
      SELECT CMND INTO V_CMND FROM NHANVIEN WHERE TRIM(UPPER(MANV))=TRIM(UPPER(V_MANV));
           
      UPDATE NHANVIEN SET CMND_ENCRYPT = ENCRYPT(V_CMND, UTL_RAW.BIT_XOR(keyModified, UTL_I18N.STRING_TO_RAW(UPPER(TRIM(UPPER(V_MANV)))))) WHERE TRIM(UPPER(MANV))=TRIM(UPPER(V_MANV));     
      
     END LOOP;
CLOSE CUR;
END;


EXEC MAHOANV;


create or replace type record_NV as object (
      MANV VARCHAR2(7),
      HOTEN VARCHAR2(50),
      PHAI CHAR(4),
      NGAYSINH DATE,
      CMND VARCHAR(200),
      QUEQUAN VARCHAR2(50),
      SODT CHAR(11),
      CSYT CHAR(7),
      VAITRO VARCHAR2(10),
      CHUYENKHOA VARCHAR2(20)
);

create or replace type table_NV as table of record_NV;

CREATE OR REPLACE FUNCTION xemNV
RETURN Table_NV
IS
  res Table_NV := Table_NV();
  userName VARCHAR2(7);
  keyModified raw(2000);
BEGIN
  
      SELECT SYS_CONTEXT('userenv', 'SESSION_USER') INTO userName FROM DUAL;
      
      select  K into keyModified from KUNV WHERE TRIM(UPPER(U))=TRIM(UPPER(userName));
      
      SELECT record_nv(MANV,HOTEN,PHAI,NGAYSINH, QTV.DECRYPT(cmnd_encrypt, UTL_RAW.BIT_XOR(KeyModified, UTL_I18N.STRING_TO_RAW(UPPER(TRIM(UPPER(userName))))) ) , QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) BULK COLLECT INTO res FROM QTV.NHANVIEN where TRIM(UPPER(MANV)) =TRIM(UPPER(userName));
      
      
    return res;
END;

SELECT SYS_CONTEXT('userenv', 'SESSION_USER')  FROM DUAL;


insert into nhanvien (manv,hoten, cmnd) values ('qtv','TamTam','334956789');

select * from nhanvien where manv='qtv';

select * from table(qtv.xemNV);

GRANT EXECUTE ON xemNV to public;

alter session set "_ORACLE_SCRIPT"=true;

CREATE USER NV1 IDENTIFIED BY '1';

GRANT CREATE SESSON TO NV1;


--Trigger T? ??ng th�m kh�a khi t?o m?i nh�n vi�n
CREATE OR REPLACE TRIGGER TAOKHOA_USER_MOI
BEFORE INSERT ON NHANVIEN
FOR EACH ROW
DECLARE keyRaw raw(32);
BEGIN
keyRaw := DBMS_CRYPTO.RANDOMBYTES (32);
INSERT INTO KUNV(U,K) VALUES(TRIM(UPPER(:NEW.MANV)),UTL_RAW.BIT_XOR(keyRaw, UTL_I18N.STRING_TO_RAW(TRIM(UPPER(:NEW.MANV)))));
END;


CREATE OR REPLACE PROCEDURE THEMNV(I_MANV VARCHAR2, I_HOTEN VARCHAR2, I_PHAI CHAR,I_NGAYSINH DATE,I_CMND VARCHAR,I_QUEQUAN VARCHAR2,I_SODT CHAR,I_CSYT CHAR,I_VAITRO VARCHAR2,I_CHUYENKHOA VARCHAR2)
AS
COUNTT integer :=0;
keyModified raw(2000);
BEGIN
SELECT COUNT(*) INTO COUNTT FROM NHANVIEN WHERE TRIM(UPPER(MANV))=TRIM(UPPER(I_MANV));
IF COUNTT<1 THEN
INSERT INTO NHANVIEN(MANV,HOTEN,PHAI,NGAYSINH,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) VALUES (I_MANV,I_HOTEN,I_PHAI,I_NGAYSINH,I_QUEQUAN,I_SODT,I_CSYT,I_VAITRO,I_CHUYENKHOA);
select  K into keyModified from KUNV WHERE UPPER(U)=UPPER(I_MANV);
UPDATE NHANVIEN SET CMND_ENCRYPT = ENCRYPT(I_CMND, UTL_RAW.BIT_XOR(keyModified, UTL_I18N.STRING_TO_RAW(UPPER(I_MANV)))) WHERE TRIM(UPPER(MANV))= TRIM(UPPER(I_MANV));     
ELSIF (COUNTT>0) THEN
UPDATE NHANVIEN SET HOTEN=I_HOTEN,PHAI=I_PHAI,NGAYSINH=I_NGAYSINH, QUEQUAN=I_QUEQUAN,SODT=I_SODT,CSYT=I_CSYT,VAITRO=I_VAITRO,CHUYENKHOA=I_CHUYENKHOA WHERE TRIM(UPPER(MANV))=TRIM(UPPER(I_MANV));
select  K into keyModified from KUNV WHERE TRIM(UPPER(U))=TRIM(UPPER(I_MANV));
UPDATE NHANVIEN SET CMND_ENCRYPT = ENCRYPT(I_CMND, UTL_RAW.BIT_XOR(keyModified, UTL_I18N.STRING_TO_RAW(TRIM(UPPER(I_MANV))))) WHERE TRIM(UPPER(MANV))=TRIM(UPPER(I_MANV));
END IF;
END;


EXEC THEMNV('NV3','HOAITAM','NU',NULL,'334956555','LA','0999999999','CS1','NGHIEN CUU',NULL);

SELECT * FROM NHANVIEN;