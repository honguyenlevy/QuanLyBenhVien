-- Tạo VPD cho bảng HSBA
-- Tạo function 
CREATE OR REPLACE FUNCTION HSBA_VPD_FUNC(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS 
    user VARCHAR2(100);
    macsyt VARCHAR2(7);
    vtro VARCHAR2(10);
    khoa VARCHAR2(20);
    cso VARCHAR2(7);
BEGIN 
    user := SYS_CONTEXT('userenv','SESSION_USER');
    IF(SUBSTR(user,0,2)='NV' OR SUBSTR(user,0,2)='nv') THEN
    BEGIN
        SELECT VAITRO INTO vtro FROM NHANVIEN WHERE TRIM(UPPER(MANV)) = TRIM(UPPER(user)); 
        IF (vtro = 'Y/BAC SI') THEN
        BEGIN  
            RETURN 'MABS = '''  || user || ''' ';
        END;
        ELSIF (vtro = 'NGHIEN CUU') THEN
        BEGIN  
            SELECT CSYT INTO macsyt FROM NHANVIEN WHERE TRIM(UPPER(MANV)) = TRIM(UPPER(user));
            SELECT CHUYENKHOA INTO khoa FROM NHANVIEN WHERE TRIM(UPPER(MANV)) = TRIM(UPPER(user));
            RETURN 'MACSYT = '''  || macsyt || ''' OR MAKHOA = ''' || khoa || ''' ';
        END;
        END IF;
    END;
    ELSIF (SUBSTR(user,0,2)='CS' OR SUBSTR(user,0,2)='cs') THEN
        RETURN 'MACSYT = '''||TRIM(UPPER(user))||''' ';
    ELSE 
        RETURN '1=1';
    END IF;
END;
/
--Tạo policy 
BEGIN
    DBMS_RLS.ADD_POLICY 
    (
        object_schema    => 'QTV',
        object_name      => 'HSBA',
        policy_name      => 'HSBA_VPD_POLICY',
        function_schema  => 'QTV',
        policy_function  => 'HSBA_VPD_FUNC',
        statement_types  => 'SELECT, UPDATE, INSERT',
        update_check => true
   );
END;
/
-- Tạo VPD cho bảng HSBA_DV
-- Tạo function 
CREATE OR REPLACE FUNCTION HSBA_DV_VPD_FUNC(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS 
    user VARCHAR2(100);
    macsyt VARCHAR2(7);
    vtro VARCHAR2(10);
    khoa VARCHAR2(20);
    cso VARCHAR2(7);
    hsba VARCHAR(7);
BEGIN 
    user := SYS_CONTEXT('userenv','SESSION_USER');
    IF(SUBSTR(user,0,2)='NV' OR SUBSTR(user,0,2)='nv') THEN
    BEGIN
        SELECT VAITRO INTO vtro FROM NHANVIEN WHERE TRIM(UPPER(MANV)) = TRIM(UPPER(user)); 
        IF (vtro = 'Y/BAC SI') THEN
        BEGIN  
            RETURN 'MAHSBA IN (SELECT MAHSBA FROM HSBA WHERE MABS = '''  || user || ''') ';
        END;
        ELSIF (vtro = 'NGHIEN CUU') THEN
        BEGIN  
            SELECT CSYT INTO macsyt FROM NHANVIEN WHERE TRIM(UPPER(MANV)) = TRIM(UPPER(user));
            SELECT CHUYENKHOA INTO khoa FROM NHANVIEN WHERE TRIM(UPPER(MANV)) = TRIM(UPPER(user));
            RETURN 'MAHSBA IN (SELECT MAHSBA FROM HSBA WHERE MACSYT = '''  || macsyt || ''' OR MAKHOA = ''' || khoa || ''') ';
        END;
        END IF;
    END;
    ELSIF (SUBSTR(user,0,2)='CS' OR SUBSTR(user,0,2)='cs') THEN
        
        RETURN 'MAHSBA IN (SELECT MAHSBA FROM HSBA WHERE MACSYT = '''||TRIM(UPPER(user))||''') ';
    ELSE 
        RETURN '1=1';
    END IF;
END;
/
--Tạo policy 
BEGIN
    DBMS_RLS.ADD_POLICY 
    (
        object_schema    => 'QTV',
        object_name      => 'HSBA_DV',
        policy_name      => 'HSBA_DV_VPD_POLICY',
        function_schema  => 'QTV',
        policy_function  => 'HSBA_DV_VPD_FUNC',
        statement_types  => 'SELECT, UPDATE, INSERT',
        update_check => true
   );
END;
/
-- Tạo VPD cho bảng NHANVIEN
-- Tạo function 
CREATE OR REPLACE FUNCTION NHANVIEN_VPD_FUNC(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR2(100);
BEGIN
    user := SYS_CONTEXT('userenv','SESSION_USER');
    IF(SUBSTR(user,0,2)='NV' OR SUBSTR(user,0,2)='nv') THEN
        RETURN 'MAnv = '''  || user || ''' ';
    ELSE
        RETURN '1=1';
END IF;
END;
/
--Tạo policy 
BEGIN
    DBMS_RLS.ADD_POLICY 
    (
        object_schema    => 'QTV',
        object_name      => 'NHANVIEN',
        policy_name      => 'NHANVIEN_VPD_POLICY',
        function_schema  => 'QTV',
        policy_function  => 'NHANVIEN_VPD_FUNC',
        statement_types  => 'SELECT, UPDATE',
        update_check => true
   );
END;
/
-- Tạo VPD cho bảng BENHNHAN
-- Tạo function 
CREATE OR REPLACE FUNCTION BENHNHAN_VPD_FUNC(p_schema VARCHAR2, p_obj VARCHAR2)
RETURN VARCHAR2
AS
    user VARCHAR2(100);
BEGIN
    user := SYS_CONTEXT('userenv','SESSION_USER');
    IF(SUBSTR(user,0,2)='BN' OR SUBSTR(user,0,2)='bn') THEN
    RETURN 'MABN = '''  || user || ''' ';
    ELSE
    RETURN '1=1';
END IF;
END;
/
--Tạo policy 
BEGIN
    DBMS_RLS.ADD_POLICY 
    (
        object_schema    => 'QTV',
        object_name      => 'BENHNHAN',
        policy_name      => 'BENHNHAN_VPD_POLICY',
        function_schema  => 'QTV',
        policy_function  => 'BENHNHAN_VPD_FUNC',
        statement_types  => 'select, update',
        update_check => true
   );
END;