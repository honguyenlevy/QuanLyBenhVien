-- Tạo hàm BENHNHAN_VPD_FUNC
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
        statement_types  => 'select, update'
   );
END;