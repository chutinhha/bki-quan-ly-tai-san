﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="F308_TH_HTSD_nha_dat_Chi_tiet_theo_loai_hinh_don_vi.aspx.cs" Inherits="BaoCao_F308_TH_HTSD_nha_dat_Chi_tiet_theo_loai_hinh_don_vi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="cssTable">
        <tr>
            <td class="cssPageTitleBG" colspan="6">
                <span class="cssPageTitle">TỔNG HỢP HIỆN TRẠNG SỬ DỤNG NHÀ, ĐẤT</span> <span class="expand-collapse-text">
                </span>
                <br />
                <span class="cssPageTitle">Phần 2: Chi tiết theo loại hình đơn vị</span><span class="expand-collapse-text initial-expand"></span>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:ValidationSummary ID="vdsCategory" runat="server" CssClass="cssManField" Font-Bold="true"
                    ValidationGroup="m_vlg_tai_san_nha_dat" />
                <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField" />
            </td>
        </tr>
        <tr>
            <td align="right" colspan="1" style="width: 15%">
                <span class="cssManField">Bộ, tỉnh:</span>
            </td>
            <td style="width: 34%">
                <asp:DropDownList ID="m_cbo_bo_tinh" Width="90%" runat="Server" AutoPostBack="True"
                    class="cssDorpdownlist" TabIndex="1">
                </asp:DropDownList>
            </td>
            <td style="width: 1%">
            </td>
            <td align="right" style="width: 15%">
                <span class="cssManField">Đơn vị chủ quản:</span>
            </td>
            <td style="width: 34%">
                <asp:DropDownList ID="m_cbo_don_vi_chu_quan" Width="90%" runat="Server" class="cssDorpdownlist"
                    TabIndex="2">
                </asp:DropDownList>
            </td>
            <td style="width: 1%">
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td align="left">
                <asp:Button ID="m_cmd_loc_du_lieu" AccessKey="l" CssClass="cssButton" runat="server"
                    Width="98px" Text="Lọc dữ liệu(l)" Height="23px" TabIndex="5" OnClick="m_cmd_loc_du_lieu_Click" />
                <asp:Button ID="m_cmd_xuat_excel" AccessKey="x" CssClass="cssButton" runat="server"
                    Width="98px" Text="Xuất Excel (x)" Height="22px" />
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <table border="0" cellspacing="0" cellpadding="0" width="100%" class="cssTable">
        <tr>
            <td class="cssPageTitleBG">
                <span class="cssPageTitle">Chi tiết tài sản</span> <span class="expand-collapse-text initial-expand">
                </span><span class="expand-collapse-text"></span>
            </td>
        </tr>
        <tr>
            <td style="width: 10%">
                <asp:GridView ID="m_grv_tai_san_nha_dat" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                    EmptyDataText="Không có dữ liệu phù hợp!" Width="100%" DataKeyNames="ID" CellPadding="0"
                    ForeColor="#333333" AllowSorting="True" PageSize="10" ShowHeader="true">
                    <Columns>
                        <asp:HyperLinkField HeaderText="TÀI SẢN" HeaderStyle-Width="21.25%" DataTextField="TEN_TAI_SAN"
                            HeaderStyle-HorizontalAlign="LEFT" />
                        <asp:TemplateField HeaderStyle-Width="7.142%" ItemStyle-Width="7.142%" ItemStyle-HorizontalAlign="Right">
                            <HeaderTemplate>
                                SỐ LƯỢNG
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Eval("SO_LUONG", "{0:#,###.##}")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-Width="8.75%" ItemStyle-Width="8.75%" ItemStyle-HorizontalAlign="Right">
                            <HeaderTemplate>
                                DIỆN TÍCH
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%#Eval("TONG_DIEN_TICH", "{0:#,###.##}")%>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderStyle-Width="50%" HeaderStyle-Height="110px">
                            <HeaderTemplate>
                                <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;">
                                    <tr>
                                        <td colspan="7" style="height: 50px">
                                            HIỆN TRẠNG SỬ DỤNG
                                            <br />
                                            (m2)
                                        </td>
                                    </tr>
                                    <tr>
                                        <td rowspan="2" style="width: 7.142%; height: 60px">
                                            Trụ sở làm việc
                                        </td>
                                        <td rowspan="2" style="width: 7.142%">
                                            Cơ sở HĐSN
                                        </td>
                                        <td rowspan="1" colspan="5">
                                            Sử dụng khác
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 7.142%">
                                            Làm nhà ở
                                        </td>
                                        <td style="width: 7.142%">
                                            Cho thuê
                                        </td>
                                        <td style="width: 7.142%">
                                            Bỏ trống
                                        </td>
                                        <td style="width: 7.142%">
                                            Bị lấn chiếm
                                        </td>
                                        <td style="width: 7.142%">
                                            Khác
                                        </td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                    <tr>
                                        <td style="width: 7.142%; height: 40px; border-right: 1px solid gray;" align="right">
                                            <%# Eval("DT_TRU_SO_LAM_VIEC", "{0:#,###.##}")%>
                                        </td>
                                        <td style="width: 7.142%; border-right: 1px solid gray;" align="right">
                                            <%# Eval("DT_CO_SO_HDSN", "{0:#,###.##}")%>
                                        </td>
                                        <td style="width: 7.142%; border-right: 1px solid gray;" align="right">
                                            <%# Eval("DT_LAM_NHA_O ", "{0:#,###.##}")%>
                                        </td>
                                        <td style="width: 7.142%; border-right: 1px solid gray;" align="right">
                                            <%# Eval("DT_CHO_THUE", "{0:#,###.##}")%>
                                        </td>
                                        <td style="width: 7.142%; border-right: 1px solid gray;" align="right">
                                            <%# Eval("DT_BO_TRONG","{0:#,###.##}")%>
                                        </td>
                                        <td style="width: 7.142%; border-right: 1px solid gray;" align="right">
                                            <%# Eval("DT_BI_LAN_CHIEM", "{0:#,###.##}")%>
                                        </td>
                                        <td style="width: 7.142%" align="right">
                                            <%# Eval("DT_KHAC", "{0:#,###.##}")%>
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
</asp:Content>
