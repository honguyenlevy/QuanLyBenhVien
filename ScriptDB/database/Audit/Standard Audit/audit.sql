alter system set audit_trail='db','extended' scope=spfile;

--�	Audit vi?c th�m, x�a, c?p nh?t d? li?u b?ng CSYT c?a DBA 
audit insert, delete, update on QTV.CSYT by access;

--noaudit all on qtv.CSYT;

--�	Audit vi?c th�m x�a, c?p nh?ta d? li?u cho b?ng nh�n vi�n 
audit insert,delete, update on QTV.NHANVIEN by access;
--noaudit all on qtv.NHANVIEN;

--�	Audit vi?c th?c thi procedure themHSBA 
AUDIT EXECUTE ON THEMHSBA BY ACCESS;

--noaudit all on qtv.THEMHSBA;

--�	Audit vi?c xem, th�m, x�a, s?a c?a b?ng kh�a ng??i d�ng UK
AUDIT INSERT,UPDATE,DELETE ON QTV.UKNHANVIEN;

--noaudit all on qtv.UKNHANVIEN;

AUDIT INSERT,UPDATE,DELETE ON QTV.UKHSBA;
--noaudit all on qtv.UKHSBA;

COMMIT;

