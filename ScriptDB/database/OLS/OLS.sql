CREATE TABLE THONGBAO
(
STT NUMBER,
NOIDUNG NVARCHAR2(500),
NGAYGIO DATETIME,
DIADIEM NVARCHAR(500)
)

-- QTV LÀ TÀI KHOẢN NẮM QUYỀN DBA CỦA MÁY TUI
--NV_XXX LÀ KHÓA CHÍNH CỦA BẢNG NHÂN VIÊN

ALTER USER lbacsys IDENTIFIED BY lbacsys ACCOUNT UNLOCK;
CONN lbacsys/lbacsys

EXEC LBACSYS.CONFIGURE_OLS;
EXEC LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS;

--quyền tạo các thành phần của table
GRANT EXECUTE ON sa_components TO QTV WITH GRANT OPTION;
--quyền gán label cho tài khoản
GRANT EXECUTE ON sa_user_admin TO QTV WITH GRANT OPTION;
--quyền tạo các label
GRANT EXECUTE ON sa_label_admin TO QTV WITH GRANT OPTION;
--quyền gán policy cho các bảng
GRANT EXECUTE ON sa_policy_admin TO QTV WITH GRANT OPTION;
--chuyển chuỗi thành số của label
GRANT EXECUTE ON CHAR_TO_LABEL TO QTV WITH GRANT OPTION;

GRANT LBAC_DBA TO QTV;
--gán quyền thực thi các hàm của sa_sysdbs (tạo policy)
GRANT EXECUTE ON sa_sysdba TO QTV;
GRANT EXECUTE ON to_lbac_data_label TO QTV;

--MAC các thông báo
--khi QTV tạo chính sách thì quyền thực thi mặc định được giao cho lbacsys
BEGIN
  SA_SYSDBA.CREATE_POLICY (
    policy_name => 'ThongBao_policy',
    column_name => 'ThongBao_label'
  );
END;
/

--phải gán role ThongBao_policy_DBA cho QTV thì user này mới có thể quản lý policy này (dùng lbacsys gán)
GRANT ThongBao_policy_DBA TO QTV; 


--tạo các thành phần của nhãn
--mức độ bí mật, vừa là cho trưởng ngành, thấp là tất cả các giáo viên của khoa, cao là cho các trưởng phó khoa
EXECUTE SA_COMPONENTS.CREATE_LEVEL('ThongBao_policy',60,'C','Cao');  
EXECUTE SA_COMPONENTS.CREATE_LEVEL('ThongBao_policy',40,'V','Vừa');
EXECUTE SA_COMPONENTS.CREATE_LEVEL('ThongBao_policy',20,'T','Thấp');

EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('ThongBao_policy',100,'NGOAI','Điều trị ngoại trú');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('ThongBao_policy',120,'NOI','Điều trị nội trú');
EXECUTE SA_COMPONENTS.CREATE_COMPARTMENT('ThongBao_policy',130,'CHUYENSAU','Điều trị chuyên sâu');

EXECUTE SA_COMPONENTS.CREATE_GROUP('ThongBao_policy',1,'TT','Trung tâm');
EXECUTE SA_COMPONENTS.CREATE_GROUP('ThongBao_policy',2,'CTT','Cận trung tâm');
EXECUTE SA_COMPONENTS.CREATE_GROUP('ThongBao_policy',2,'NT','Ngoại thành');

EXECUTE SA_USER_ADMIN.SET_USER_PRIVS('ThongBao_policy','QTV','FULL,PROFILE_ACCESS');

--tạo các label sẽ sử dụng
BEGIN
 -- TẤT CẢ GIÁM ĐỐC
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 1000, label_value => 'C');
   
   --giám đốc sở NGOẠI TRÚ
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 1, label_value => 'C:NGOAI:TT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 2, label_value => 'C:NGOAI:CTT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 3, label_value => 'C:NGOAI:NT');
   
    
    --giám đốc sở NỘI TRÚ
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 11, label_value => 'C:NOI:TT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag =>12, label_value => 'C:NOI:CTT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 13, label_value => 'C:NOI:NT');
   
   --giám đốc sở NỘI TRÚ
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 21, label_value => 'C:CHUYENSAU:TT');
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag =>22, label_value => 'C:CHUYENSAU:CTT');
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'THONGBAO_POLICY', label_tag => 23, label_value => 'C:CHUYENSAU:NT');
   
  --tất cả nhân viên điều trị ngoại trú
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 100, label_value => 'T:NGOAI:TT');
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 101, label_value => 'T:NGOAI:CTT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 102, label_value => 'T:NGOAI:NT');
  
  --tất cả nhân viên điều trị nội trú
  
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 110, label_value => 'T:NOI:TT');
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 111, label_value => 'T:NOI:CTT');
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 112, label_value => 'T:NOI:NT');
   
  --tất cả nhân viên ĐIỀU TRỊ chuyên sâu
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 120, label_value => 'T:CHUYENSAU:TT');
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 121, label_value => 'T:CHUYENSAU:CTT');
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 122, label_value => 'T:CHUYENSAU:NT');
  
 
  --tất cả giám đốc cơ sở y tế Ngoại trú 
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 200, label_value => 'V:NGOAI:TT');
  SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 201, label_value => 'V:NGOAI:CTT');
    SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 202, label_value => 'V:NGOAI:NT');
    
  --tất cả GIÁM ĐỐC CSYT NỘI TRÚ
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 210, label_value => 'V:NOI:TT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 211, label_value => 'V:NOI:CTT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 212, label_value => 'V:NOI:NT');
    
    
     --tất cả GIÁM ĐỐC CSYT CHUYÊN SÂU
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 210, label_value => 'V:CHUYENSAU:TT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 211, label_value => 'V:CHUYENSAU:CTT');
   SA_LABEL_ADMIN.CREATE_LABEL(policy_name => 'ThongBao_policy', label_tag => 212, label_value => 'V:CHUYENSAU:NT');
 
END;
/
show errors

--áp dụng policy vào bảng để thêm vào cột label
--phải có no_control nếu không sẽ trả về null
BEGIN
  SA_POLICY_ADMIN.APPLY_TABLE_POLICY(
    policy_name   => 'ThongBao_policy',
    schema_name   => 'QTV',
    table_name    => 'THONGBAO',
    table_options => 'NO_CONTROL');
END;
/

--cập nhật label number cho bảng (phải có mới chạy được)
--UPDATE ThongBao SET ThongBao_label = CHAR_TO_LABEL('ThongBao_policy','T');

--apply policy vào bảng 1 lần nữa
BEGIN
  SA_POLICY_ADMIN.REMOVE_TABLE_POLICY('ThongBao_policy','QTV','THONGBAO');
  SA_POLICY_ADMIN.APPLY_TABLE_POLICY (
    policy_name => 'ThongBao_policy',
    schema_name => 'QTV',
    table_name  => 'THONGBAO',
    table_options => 'READ_CONTROL,WRITE_CONTROL');
END;
/
show errors;

--gán nhãn cho NHÂN VIÊN
BEGIN
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV1', 'C:NOI:TT'); -- GIAM DOC SO NOI TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV2', 'C:NOI:CTT'); -- GIAM DOC SO NOI TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV3', 'C:NOI:NT'); -- GIAM DOC SO NOI TRU NGOAI THANH
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV4', 'V:NOI:TT'); --GIAM DOC CSYT NOI TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV5', 'V:NOI:CTT'); --GIAM DOC CSYT NOI TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV6', 'V:NOI:NT'); --GIAM DOC CSYT NOI TRU NGOAI THANH
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV7', 'T:NOI:TT'); -- NV NOI TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV8', 'T:NOI:CTT'); -- NV NOI TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV9', 'T:NOI:NT'); -- NV NOI TRU NGOAI THANH



  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV11', 'C:NGOAI:TT'); -- GIAM DOC SO NGOAI TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV12', 'C:NGOAI:CTT'); -- GIAM DOC SO NGOAI TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV13', 'C:NGOAI:NT'); -- GIAM DOC SO NGOAI TRU NGOAI THANH
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV14', 'V:NGOAI:TT'); --GIAM DOC CSYT NGOAI TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV15', 'V:NGOAI:CTT'); --GIAM DOC CSYT NGOAI TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV16', 'V:NGOAI:NT'); --GIAM DOC CSYT NGOAI TRU NGOAI THANH
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV17', 'T:NGOAI:TT'); -- NV NGOAI TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV18', 'T:NGOAI:CTT'); -- NV NGOAI TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV19', 'T:NGOAI:NT'); -- NV NGOAI TRU NGOAI THANH
  
  
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV21', 'C:CHUYENSAU:TT'); -- GIAM DOC SO CHUYEN SAU TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV22', 'C:CHUYENSAU:CTT'); -- GIAM DOC SO CHUYEN SAU TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV23', 'C:CHUYENSAU:NT'); -- GIAM DOC SO CHUYEN SAU TRU CHUYENSAU THANH
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV24', 'V:CHUYENSAU:TT'); --GIAM DOC CSYT CHUYEN SAU TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV25', 'V:CHUYENSAU:CTT'); --GIAM DOC CSYT CHUYEN SAU TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV26', 'V:CHUYENSAU:NT'); --GIAM DOC CSYT CHUYEN SAU TRU CHUYENSAU THANH
  
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV27', 'T:CHUYENSAU:TT'); -- NV CHUYEN SAU TRU TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV28', 'T:CHUYENSAU:CTT'); -- NV CHUYEN SAU TRU CAN TRUNG TAM
  SA_USER_ADMIN.SET_USER_LABELS('ThongBao_policy', 'NV29', 'T:CHUYENSAU:NT'); -- NV CHUYEN SAU TRU CHUYENSAU THANH
  
  
END;


GRANT SELECT, INSERT, UPDATE ON THONGBAO TO NHANVIEN;

--- GRANT NHANVIEN TO NV1........ NV29

GRANT EXECUTE ON CHAR_TO_LABEL TO NHANVIEN;

select * from QTV.THONGBAO;

--NV1 chạy cái này
insert into QTV.THONGBAO values (1,'Các cơ sở phải phấn đấu để phục vụ bệnh nhân ', CHAR_TO_LABEL('ThongBao_policy', 'C'));
insert into QTV.THONGBAO values (2,'Chúc mừng bác sĩ Nguyễn Văn Meo Meo  đã đạt thành tích xuất sắc', CHAR_TO_LABEL('ThongBao_policy', 'T:NOI:TT'));
