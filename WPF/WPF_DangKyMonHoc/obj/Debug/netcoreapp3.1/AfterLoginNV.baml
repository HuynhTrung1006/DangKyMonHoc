   M S B A M L   `   `   `  ����K  GWpf_DangKyMonHoc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Wpf_DangKyMonHocWpf_DangKyMonHoc  5   	   #    Wpf_DangKyMonHoc.AfterLoginNV   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Wpf_DangKyMonHoc     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  AfterLoginNV��5
   	    � WindowState$ 	Maximized=�6   
�������$	��450��6I   $	��800��6V   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��1��6   ���	#FF2B52AB.+�5      �� $7��1TRƯỜNG ĐẠI HỌC CÔNG NGHỆ SÀI GÒN��6   $��Center=�6F   $��Center=�6a   $��25(�6~   $��	ExtraBold"�6�   6�   �� 5      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5      '  !MaterialDesignThemes.Wpf.PopupBox  $��10q�6+      PlacementMode$ BottomAndAlignRightEdges=�67      	StaysOpen$ False��6`      PopupContent. 5      �� $	��120��6!   .+�5      �� -   5        $��btnDoimatkhau��5   8   $��Đổi Mật Khẩu��6!   6M   �� 5      �� 5      -   5        $��btnDangXuat��5   5   $��Đăng xuất��6!   6H   5      5      5!      5"      � 5#   
   -   5         �Name$ GridMenu��5#      $��0��6!   $��3��61   $	��200��6B   $
��Left=�6N   ���	#FF2B52AB.+�5$      �� .+�5%      � $	��100��6   ���	#FF2B52AB.+�5&      �� $��/Assets/Logo_STU.png��6   $	��200��6:   $��90��6F   5.      �� 5/      
�������.@�50      �� �� 51      $��50��6#   .��52      �� $ 
Horizontal=�6%   .+�53      �� -   5        $��btnQuanLySinhVien��57   %   $��Quản lý Sinh Viên ��53   %   $��Center=�6r   $��Right=�54   %   
�������$
��Bold"�56   %   ��53   E   Z� ��6[   Z� 57   >   59      5:      �� 5<      $��60��6#   .��5=      �� $ 
Horizontal=�6%   .+�5>      �� -   5        $��btnQlGiangVien��5>   D   $��Quản lý Giảng Viên��6%   $
��Bold"�6w   $��Center=�6�   $��Right=�6�   
���������6�   Z� ��6�   Z� 6�   5?      5@      �� 5A      $��60��6#   .��5B      �� $ 
Horizontal=�6%   .+�5C      �� -   5        $��btnQlLop��5C   P   $��Quản lý Lớp��6%   $
��Bold"�6>   $��Center=�6�   $��Right=�6�   
���������6x   Z� ��6�   Z� 6�   5D      5E      �� 5F      $��60��6#   .��5G      �� $ 
Horizontal=�6%   .+�5H      �� -   5        $��btnQlMonHoc��5H   T   $��Quản lý Môn Học��6%   $
��Bold"�6B   $��Center=�6�   $��Right=�6�   
���������6�   Z� ��6�   Z� 6�   5I      5J      �� 5K      $��60��6#   .��5L      �� $ 
Horizontal=�6%   .+�5M      �� -   5        $��btnQlCongDangKy��5M   X   $#��Quản lý Cổng Đăng ký��6%   $
��Bold"�6F   $��Center=�6�   $��Right=�6�   
���������6�   Z� ��6�   Z� 6�   5N      5O      �� 5P      $��60��6#   .��5Q      �� $ 
Horizontal=�6%   .+�5R      �� -	   5        $��btnCTDT��5R   W   $!��Chương Trình Đào Tạo��6%   $
��Bold"�6E   $��Center=�6�   $��Right=�6�   
���������6|   Z� ��6�   Z� 6�   5S      5T      �� 5U      $��60��6#   .��5V      �� $ 
Horizontal=�6%   .+�5W      �� -
   5        $��btnLopMh��5W   Z   $#��Quản lý Lớp môn học��6%   $
��Bold"�6H   $��Center=�6�   $��Right=�6�   
���������6�   Z� ��6�   Z� 6�   5X      5Y      5Z      5[      5\      � 5]   
   $��1��6   $��1��6   .+�5_      � .+�5`      ]� .+�5a      o� $	��Top=�6   $
��auto��60   .@�5b      m� $��Người dùng��6#   $��
ExtraBlack"�67   .@�5c      m� -   5        $��	btnChucVu��5c   B   $��Quản lý Chức Vụ��6'   6S   m� 5d      -   5        $��btnKhoa��5d   ?   $��Quản lý Khoa��6'   6N   m� 5e      -   5        $��btnNganh��5e   @   $��Quản lý Ngành��6'   6P   m� 5f      -   5        $��btnNienKhoa��5f   D   $��Quản lý Niên Khóa��6'   6W   5g      m� 5h      $��Đăng ký môn học��6#   $��
ExtraBlack"�6<   .@�5i      m� -   5        $��	btnNamHoc��5i   8   $��
Năm Học��6'   6I   m� 5j      -   5        $��btnHocKyDKMH��5j   7   $��
Học kỳ��6'   6K   5k      m� 5l      $!��Chương trình đào tạo��6#   $��
ExtraBlack"�6A   .@�5m      m� -   5        $��btnKhoiKienThuc��5m   ?   $��Khối kiến thức��6'   6V   m� 5n      -   5        $��btnHeDaoTao��5n   ;   $��Hệ đào tạo��6'   6N   m� 5o      -   5        $��btnHocKyCTDT��5o   7   $��
Học Kỳ��6'   6K   5p      5q      5r      5s      5t      � 5u   
   $��1��6   $��2��6    5v      �� 5w      $
��153* �6#   �� 5x      $	��47* �6#   .+�5z       � -   5        	  �Name$	 ContentArea��5z      
  � NavigationUIVisibility$
 Hidden=�6)   $��2��6I   5|      5}      5~      