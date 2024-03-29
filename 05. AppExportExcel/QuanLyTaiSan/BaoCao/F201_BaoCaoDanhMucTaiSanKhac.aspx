﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    EnableEventValidation="false" CodeFile="F201_BaoCaoDanhMucTaiSanKhac.aspx.cs"
    Inherits="Default2" %>

<%@ Import Namespace="WebUS" %>
<%@ Import Namespace="WebDS.CDBNames" %>
<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                    <tr>
                        <td class="cssPageTitleBG" colspan="4">
                            <asp:Label ID="m_lbl_tieu_de" runat="Server" class="cssPageTitle"></asp:Label>
                            <span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text">
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <asp:ValidationSummary ID="vdsCategory" runat="server" CssClass="cssManField" Font-Bold="true" />
                            <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 15%;">
                            &nbsp;
                        </td>
                        <td style="width: 20%;">
                            &nbsp;
                        </td>
                        <td align="right" style="width: 15%;">
                            &nbsp;
                        </td>
                        <td style="width: 20%;">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right" colspan="1" style="width: 15%">
                            <span class="cssManField">Bộ, tỉnh:</span>
                        </td>
                        <td style="width: 35%">
                            <asp:DropDownList ID="m_cbo_bo_tinh" Width="90%" runat="Server" AutoPostBack="True"
                                OnSelectedIndexChanged="m_cbo_bo_tinh_SelectedIndexChanged" TabIndex="1">
                            </asp:DropDownList>
                        </td>
                        <td align="right" style="width: 15%">
                            <span class="cssManField">Đơn vị chủ quản:</span>
                        </td>
                        <td style="width: 35%">
                            <asp:DropDownList ID="m_cbo_don_vi_chu_quan" Width="90%" runat="Server" AutoPostBack="True"
                                OnSelectedIndexChanged="m_cbo_don_vi_chu_quan_SelectedIndexChanged" TabIndex="2">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="cssManField">Loại hình đơn vị:</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="m_cbo_loai_hinh_don_vi" runat="Server" OnSelectedIndexChanged="m_cbo_loai_hinh_don_vi_SelectedIndexChanged"
                                Width="90%" AutoPostBack="True">
                            </asp:DropDownList>
                        </td>
                        <td align="right">
                            <span class="cssManField">Đơn vị sử dụng tài sản:</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="m_cbo_don_vi_su_dung_tai_san" runat="Server" AutoPostBack="True"
                                TabIndex="3" Width="90%">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="cssManField">Loại tài sản</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="m_cbo_loai_tai_san" runat="Server" TabIndex="4" Width="90%">
                            </asp:DropDownList>
                        </td>
                        <td align="right">
                            <span class="cssManField">Trạng thái:</span>
                        </td>
                        <td>
                            <asp:DropDownList ID="m_cbo_trang_thai" runat="Server" TabIndex="4" Width="90%">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="m_lbl_tim_kiem" runat="server" CssClass="cssManField" 
                                Visible="False">Tìm kiếm:</asp:Label>
                        </td>
                        <td valign="top" colspan="2">
                            <asp:TextBox ID="m_txt_tim_kiem" runat="Server" Width="63%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            &nbsp;
                        </td>
                        <td valign="top" colspan="2">
                            <asp:HiddenField ID="hdf_id" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td colspan="2" align="left">
                            <asp:Button ID="m_cmd_tim_kiem" AccessKey="l" CssClass="cssButton" runat="server"
                                Height="24px" Width="98px" Text="Lọc dữ liệu(l)" OnClick="m_cmd_tim_kiem_Click" />&nbsp;
                            <asp:Button ID="m_cmd_xuat_excel" AccessKey="x" CssClass="cssButton" runat="server"
                                Height="24px" Width="98px" Text="Xuất Excel (x)" OnClick="m_cmd_xuat_excel_Click" />&nbsp;
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                    <tr>
                        <td class="cssPageTitleBG" colspan="6">
                            <asp:Label ID="m_lbl_title" runat="server" Text="DANH MỤC TÀI SẢN KHÁC (TRỪ TRỤ SỞ LÀM VIỆC, CƠ SỞ HOẠT ĐỘNG
                                SỰ NGHIỆP VÀ XE Ô TÔ)" CssClass="cssPageTitle"></asp:Label><span class="expand-collapse-text initial-expand">
                                </span><span class="expand-collapse-text"></span>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                        </td>
                        <td align="left">
                            <asp:Label ID="m_lbl_thong_bao" Visible="false" runat="server" CssClass="cssManField" />
                        </td>
                        <td align="left">
                        </td>
                        <td align="left">
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="3" style="height: 450px;" valign="top">
                            <asp:GridView ID="m_grv_danh_sach_tai_san_khac" runat="server" AllowPaging="True"
                                AutoGenerateColumns="False" Width="100%" DataKeyNames="ID" CellPadding="0" ForeColor="#333333"
                                AllowSorting="True" PageSize="15" ShowHeader="true" EmptyDataText="Không có dữ liệu phù hợp"
                                OnPageIndexChanging="m_grv_danh_sach_tai_san_khac_PageIndexChanging">
                                <Columns>
                                    <asp:TemplateField HeaderStyle-Width="2%" ItemStyle-HorizontalAlign="center" HeaderText="STT">
                                        <ItemTemplate>
                                            <%# Container.DataItemIndex + 1 %>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Chi tiết">
                                        <ItemTemplate>
                                            <asp:HyperLink ID="m_lnk_lop_mon_detail" runat="server" Target="_blank" ToolTip="Xem chi tiết"
                                                NavigateUrl='<%# "~/ChucNang/F200_DanhMucTaiSanKhac.aspx?"+CONST_QLDB.MA_THAM_SO_URL.ID_TAI_SAN_KHAC+"="+Eval(V_DM_TAI_SAN_KHAC.ID) %>'
                                                ImageUrl="~/Images/Button/detail.png">Chi tiết</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Đơn vị bộ tỉnh" DataField="TEN_DV_BO_TINH" />
                                    <asp:BoundField HeaderText="Đơn vị chủ quản" DataField="TEN_DV_CHU_QUAN" />
                                    <asp:BoundField HeaderText="Đơn vị sử dụng" DataField="TEN_DV_SU_DUNG" />
                                    <asp:BoundField HeaderText="Trạng thái" DataField="TEN_TRANG_THAI" />
                                    <asp:BoundField HeaderText="Tình trạng" DataField="TEN_TINH_TRANG" />
                                    <asp:TemplateField HeaderText="Chi tiết tài sản" Visible="false">
                                        <ItemTemplate>
                                            <asp:HyperLink ToolTip="Chi tiết tài sản" ImageUrl="../Images/Button/detail.png"
                                                ID="lbt_hop_dong_gv" runat="server" NavigateUrl=''></asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:HyperLinkField HeaderText="Tên tài sản" DataTextField="TEN_TAI_SAN" NavigateUrl=""
                                        HeaderStyle-Width="20%" />
                                    <asp:BoundField HeaderText="Ký hiệu" DataField="KY_HIEU" />
                                    <asp:BoundField HeaderText="Năm sản xuất" ItemStyle-HorizontalAlign="Center" DataField="NAM_SAN_XUAT"
                                        HeaderStyle-Width="3.5%">
                                        <ItemStyle HorizontalAlign="Center"></ItemStyle>
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="Năm sử dụng" ItemStyle-HorizontalAlign="Center" DataField="NAM_SU_DUNG"
                                        HeaderStyle-Width="3.5%" />
                                    <asp:TemplateField HeaderStyle-Width="25%" HeaderStyle-Height="75px">
                                        <HeaderTemplate>
                                            <table border="1" cellspacing="0" cellpadding="3" width="100%" style="border-collapse: collapse;
                                                height: 100%; color: white">
                                                <tr>
                                                    <td colspan="3" style="height: 35px; text-align: center">
                                                        Giá trị theo sổ kế toán (VNĐ)
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="width: 66%; text-align: center">
                                                        Nguyên giá
                                                    </td>
                                                    <td rowspan="2" style="width: 33%; text-align: center">
                                                        Giá trị còn lại
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 33%; text-align: center">
                                                        Nguồn NS
                                                    </td>
                                                    <td style="width: 33%; text-align: center">
                                                        Nguồn khác
                                                    </td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <HeaderStyle CssClass="" />
                                        <ItemTemplate>
                                            <table border="0" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                                                text-align: right">
                                                <tr>
                                                    <td style="width: 33%; border-right: 1px solid gray" height="40px">
                                                        <%# Eval("NGUON_NS", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 33%; border-right: 1px solid gray">
                                                        <%# Eval("NGUON_KHAC", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 33%">
                                                        <%# Eval("GIA_TRI_CON_LAI", "{0:#,###}")%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField>
                                        <HeaderTemplate>
                                            <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                                                height: 100%; color: white">
                                                <tr>
                                                    <td colspan="4" style="height: 39px; text-align: center">
                                                        Hiện trạng sử dụng (cái, chiếc)
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td rowspan="2" style="width: 25%; text-align: center">
                                                        Quản lý nhà nước
                                                    </td>
                                                    <td colspan="2" style="width: 50%; text-align: center">
                                                        Hoạt đông sự nghiệp
                                                    </td>
                                                    <td rowspan="2" style="width: 25%; text-align: center">
                                                        Khác
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 25%; text-align: center">
                                                        Kinh doanh
                                                    </td>
                                                    <td style="width: 25%; text-align: center">
                                                        Không kinh doanh
                                                    </td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <table border="0" cellspacing="0" cellpadding="2" width="100%" style="text-align: right;
                                                border-collapse: collapse">
                                                <tr>
                                                    <td style="width: 25%; border-right: 1px solid gray" height="40px">
                                                        <%# Eval("QLNN", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 25%; border-right: 1px solid gray"">
                                                        <%# Eval("KINH_DOANH", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 25%; border-right: 1px solid gray">
                                                        <%# Eval("KHONG_KINH_DOANH", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 25%">
                                                        <%# Eval("HD_KHAC", "{0:#,###}")%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#810c15" Font-Bold="True" ForeColor="White" />
                                <PagerSettings Position="TopAndBottom" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle CssClass="cssSelectedRow" BackColor="#C5BBAF" Font-Bold="True"
                                    ForeColor="#333333"></SelectedRowStyle>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="m_cmd_xuat_excel" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
    <asp:UpdateProgress ID="Updateprogress1" runat="server">
        <ProgressTemplate>
            <div class="cssLoadWapper">
                <div class="cssLoadContent">
                    <img src="../Images/loadingBar.gif" alt="" />
                    <p>
                        Đang gửi yêu cầu, hãy đợi ...</p>
                </div>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
</asp:Content>
