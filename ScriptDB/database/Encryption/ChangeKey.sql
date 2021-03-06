CREATE TABLE KUNV_COPY
(
U VARCHAR2(7) PRIMARY KEY,
K RAW(2000)
)

CREATE OR REPLACE PROCEDURE RE_MaHoaNV
AS
    keyModified raw(2000);
    CURSOR CUR IS SELECT MANV FROM NHANVIEN;
    V_MANV VARCHAR2(7);
    V_CMND VARCHAR(20);
    OLD_KEY RAW(2000); 
BEGIN
OPEN CUR;
   LOOP 
     FETCH CUR INTO V_MANV;
     EXIT WHEN CUR%NOTFOUND;
     
      select  K into keyModified from KUNV WHERE TRIM(UPPER(U))=TRIM(UPPER(V_MANV));
      
      SELECT K INTO OLD_KEY FROM KUNV_COPY WHERE TRIM(UPPER(U))=TRIM(UPPER(V_MANV));
       
      SELECT DECRYPT(CMND, UTL_RAW.BIT_XOR(OLD_KEY, UTL_I18N.STRING_TO_RAW(TRIM(UPPER(V_MANV))))) INTO V_CMND FROM NHANVIEN WHERE TRIM(UPPER(MANV))=TRIM(UPPER(V_MANV));
              
     UPDATE NHANVIEN SET CMND = ENCRYPT(V_CMND, UTL_RAW.BIT_XOR(keyModified, UTL_I18N.STRING_TO_RAW(TRIM(UPPER(V_MANV))))) WHERE TRIM(UPPER(MANV))=TRIM(UPPER(V_MANV));
      
     END LOOP;
CLOSE CUR;
END;


CREATE OR REPLACE PROCEDURE CHANGEKEY
AS
BEGIN
INSERT INTO KUNV_COPY(K,U)  SELECT K,U FROM KUNV;
TAOKHOANV;
RE_MAHOANV;
DELETE FROM KUNV_COPY;
END;

EXEC CHANGEKEY;

SELECT * FROM TABLE(QTV.XEMNV);