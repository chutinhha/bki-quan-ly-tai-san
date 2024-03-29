﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="F410_DeNghiXuLyOto.aspx.cs"
    Inherits="ChucNang_F410_DeNghiXuLyOto" EnableEventValidation="false" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        
    </style>
    <script type="text/javascript">
        // Hàm này dùng để check all checkbox trên lưới
        function SelectAllCheckboxes(spanChk) {
            // Added as ASPX uses SPAN for checkbox
            var oItem = spanChk.children;
            var theBox = (spanChk.type == "checkbox") ? spanChk : spanChk.children.item[0];
            xState = theBox.checked;
            elm = theBox.form.elements;

            for (i = 0; i < elm.length; i++)
                if (elm[i].type == "checkbox" && elm[i].id != theBox.id) {
                    if (elm[i].checked != xState)
                        elm[i].click();
                }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table cellspacing="0" cellpadding="2" style="width: 99%;" class="cssTable" border="0">
                <!--  Quan ly oto  -->
                <tr>
                    <td class="cssPageTitleBG" colspan="2">
                        <asp:Label ID="Label1" runat="server" CssClass="cssPageTitle" Text="Quản lý ô tô" />
                        <span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text">
                        </span>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="vdsCategory" runat="server" CssClass="cssManField" Font-Bold="true"
                            ValidationGroup="m_vlg_oto" />
                        <asp:Label ID="Label2" runat="server" CssClass="cssManField" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                            <tr>
                                <td align="right" style="width: 15%;">
                                    <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField" />
                                </td>
                                <td align="left" colspan="1" style="width: 30%">
                                    &nbsp;
                                </td>
                                <td align="right" colspan="1" style="width: 15%">
                                    &nbsp;
                                </td>
                                <td align="left" class="style1" style="width: 30%">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%;">
                                    <asp:Label ID="lblFullName14" CssClass="cssManField" runat="server" Text="Bộ, Tỉnh" />
                                </td>
                                <td align="left" colspan="1" style="width: 30%">
                                    <asp:DropDownList ID="m_ddl_bo_tinh" runat="server" Width="85%" OnSelectedIndexChanged="m_ddl_bo_tinh_SelectedIndexChanged"
                                        AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                <td align="right" colspan="1" style="width: 15%">
                                    <asp:Label ID="lblFullName15" CssClass="cssManField" runat="server" Text="Đơn vị chủ quản" />
                                    &nbsp;
                                </td>
                                <td align="left" class="style1" style="width: 30%" colspan="1">
                                    <asp:DropDownList ID="m_ddl_dv_chu_quan" runat="server" Width="85%" OnSelectedIndexChanged="m_ddl_dv_chu_quan_SelectedIndexChanged"
                                        AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%;">
                                    <asp:Label ID="lblFullName16" CssClass="cssManField" runat="server" Text="Đơn vị sử dụng tài sản" />
                                </td>
                                <td align="left" colspan="1" style="width: 30%">
                                    <asp:DropDownList ID="m_ddl_dv_sd_ts" runat="server" Width="85%" OnSelectedIndexChanged="m_ddl_dv_sd_ts_SelectedIndexChanged"
                                        AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                                <td align="right" colspan="1" style="width: 15%">
                                    <asp:Label ID="lblFullName19" CssClass="cssManField" runat="server" Text="Trạng thái ô tô" />
                                </td>
                                <td align="left" class="style1" style="width: 30%">
                                    <asp:DropDownList ID="m_ddl_trang_thai_oto" runat="server" Width="85%" OnSelectedIndexChanged="m_ddl_dv_sd_ts_SelectedIndexChanged"
                                        AutoPostBack="True">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" colspan="1" style="width: 15%">
                                    &nbsp;
                                </td>
                                <td align="left" style="width: 35%" colspan="1">
                                    &nbsp;
                                </td>
                                <td align="left" colspan="2" rowspan="2" style="width: 30%;">
                                    <span class="cssManField">Chú ý:
                                        <br />
                                        - Chọn trạng thái &quot;1-Đang sử dụng&quot;-> Ấn tìm kiếm -> Chọn tài sản lập đề
                                        nghị xử lý
                                        <br />
                                        - Chọn trạng thái &quot;2-Đề nghị xử lý&quot;-> Ấn tìm kiếm -> Chọn tài sản hủy
                                        đề nghị xử lý </span>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%;">
                                    <asp:Label ID="lbl_ghi_chu0" runat="server" CssClass="cssManField" Text="Từ khóa tìm kiếm" />
                                </td>
                                <td align="left" colspan="1" style="width: 35%">
                                    <asp:TextBox ID="m_txt_tim_kiem" runat="server" CssClass="cssTextBox" Width="85%"></asp:TextBox>
                                </td>
                                <td align="left" style="width: 15%;" colspan="1">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%;">
                                    &nbsp;
                                </td>
                                <td align="left" colspan="1" style="width: 35%">
                                    <asp:Button ID="m_cmd_tim_kiem" runat="server" AccessKey="c" CssClass="cssButton"
                                        Height="24px" OnClick="m_cmd_tim_kiem_Click" Text="Tìm kiếm(s)" Width="98px" />
                                    &nbsp;
                                    <asp:Button ID="m_cmd_xuat_excel" runat="server" CausesValidation="False" CssClass="cssButton"
                                        Height="25px" Text="Xuất Excel" Width="98px" OnClick="m_cmd_xuat_excel_Click" />
                                </td>
                                <td align="left" style="width: 15%;" colspan="1">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%;">
                                    &nbsp;
                                </td>
                                <td align="left" colspan="1" style="width: 35%">
                                    &nbsp;
                                </td>
                                <td align="left" style="width: 15%;" colspan="1">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td align="left" colspan="1" style="width: 15%">
                                    &nbsp;
                                </td>
                                <td align="left" style="width: 15%" colspan="1">
                                    &nbsp;
                                </td>
                                <td align="left" style="width: 15%" colspan="1">
                                    &nbsp;
                                </td>
                                <td align="right" style="width: 15%">
                                    <asp:HiddenField ID="m_hdf_id" runat="server" />
                                    &nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <!-- End Quan ly oto   -->
                <!-- Ket qua loc du lieu  -->
                <tr>
                    <td class="cssPageTitleBG" colspan="2">
                        <asp:Label ID="m_lbl_ket_qua_loc_du_lieu" runat="server" CssClass="cssPageTitle"
                            Text="Kết quả lọc dữ liệu" />
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="1">
                        <asp:Button ID="m_cmd_de_nghi_xu_ly" runat="server" AccessKey="c" CssClass="cssButton"
                            Text="Đề nghị xử lý" Height="24px" Width="98px" OnClick="m_cmd_de_nghi_xu_ly_Click" />
                        <asp:Button ID="m_cmd_huy_de_nghi_xu_ly" runat="server" Text="Hủy" CssClass="cssButton"
                            Height="24px" Width="98px" OnClick="m_cmd_huy_de_nghi_xu_ly_Click" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <br />
                        <asp:Label ID="m_lbl_thong_bao" runat="server" CssClass="cssManField" />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <!-- End Ket qua loc du lieu  -->
            </table>
            <table cellspacing="0" cellpadding="2" style="width: 99%;" class="cssTable">
                <!--  Gridview  -->
                <tr>
                    <td align="center" colspan="3" style="height: 450px;" valign="top">
                        &nbsp;
                        <asp:GridView ID="m_grv_dm_oto" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            Width="100%" DataKeyNames="ID" CellPadding="0" ForeColor="#333333" AllowSorting="True"
                            PageSize="15" ShowHeader="true" EmptyDataText="Không có dữ liệu phù hợp" OnPageIndexChanging="m_grv_dm_oto_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField ItemStyle-Width="2%">
                                    <HeaderTemplate>
                                        <!-- Header checkbox -->
                                        <input type="checkbox" id="chkAll" onclick="javascript:SelectAllCheckboxes(this)"
                                            runat="server" />
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <!-- cái này là checkbox, hiểu là dữ liệu của cột -->
                                        <asp:CheckBox runat="server" ID="chkItem" ToolTip='<%# Eval("ID") %>' />
                                        <asp:CheckBox runat="server" ID="chkTrangThai" Visible="false" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Tên tài sản" DataField="TEN_TAI_SAN" />
                                <asp:BoundField HeaderText="Mã tài sản" DataField="MA_TAI_SAN" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Nhãn hiệu" DataField="NHAN_HIEU" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Biển kiểm soát" DataField="BIEN_KIEM_SOAT" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Số chỗ ngồi" DataField="SO_CHO_NGOI" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Công suất xe" DataField="CONG_SUAT_XE" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Chức danh sử dụng" DataField="CHUC_DANH_SU_DUNG" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Nguồn gốc xe" DataField="NGUON_GOC_XE" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Nước sản xuất" DataField="NUOC_SAN_XUAT" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Năm sản xuất" DataField="NAM_SAN_XUAT" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Năm sử dụng" DataField="NAM_SU_DUNG" ItemStyle-HorizontalAlign="Center" />
                                <asp:TemplateField HeaderStyle-Width="20%">
                                    <HeaderTemplate>
                                        <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;">
                                            <tr>
                                                <td colspan="3" style="height: 45px">
                                                    Giá trị theo sổ kế toán
                                                    <br />
                                                    (VND)
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="width: 66%; height: 20px">
                                                    Nguyên giá
                                                </td>
                                                <td rowspan="2" style="width: 33%; height: 80px">
                                                    Giá trị còn lại
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 33%">
                                                    Nguồn NS
                                                </td>
                                                <td style="width: 33%">
                                                    Nguồn khác
                                                </td>
                                            </tr>
                                        </table>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                            <tr>
                                                <td style="width: 33%; height: 40px; border-right: 1px solid gray; text-align: right;">
                                                    <%# Eval("NGUON_NS", "{0:#,###}")%>
                                                </td>
                                                <td style="width: 33%; border-right: 1px solid gray; text-align: right;">
                                                    <%# Eval("NGUON_KHAC", "{0:#,###}")%>
                                                </td>
                                                <td style="width: 33%; text-align: right;">
                                                    <%# Eval("GIA_TRI_CON_LAI", "{0:#,###}")%>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse">
                                            <tr>
                                                <td colspan="7" style="height: 45px;">
                                                    Hiện trạng sử dụng
                                                </td>
                                            </tr>
                                            <tr>
                                                <td rowspan="2" style="width: 25%; height: 80px;">
                                                    Quản lý nhà nước
                                                </td>
                                                <td colspan="2" style="width: 50%">
                                                    Hoạt động sự nghiệp
                                                </td>
                                                <td rowspan="2" style="width: 25%">
                                                    Khác
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 25%">
                                                    Kinh doanh
                                                </td>
                                                <td style="width: 25%">
                                                    Không kinh doanh
                                                </td>
                                            </tr>
                                        </table>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                            <tr>
                                                <td style="width: 25%; height: 40px; border-right: 1px solid gray; text-align: right;">
                                                    <%# Eval("QLNN") %>
                                                </td>
                                                <td style="width: 25%; border-right: 1px solid gray; text-align: right;">
                                                    <%# Eval("KINH_DOANH") %>
                                                </td>
                                                <td style="width: 25%; border-right: 1px solid gray; text-align: right;">
                                                    <%# Eval("KHONG_KINH_DOANH") %>
                                                </td>
                                                <td style="width: 25%; text-align: right;">
                                                    <%# Eval("HD_KHAC") %>
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
                <!--End Gridview-->
            </table>
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="m_cmd_xuat_excel" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:UpdateProgress runat="server">
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
