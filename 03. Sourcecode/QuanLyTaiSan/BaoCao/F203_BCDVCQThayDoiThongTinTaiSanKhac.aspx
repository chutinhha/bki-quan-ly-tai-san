﻿<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="F203_BCDVCQThayDoiThongTinTaiSanKhac.aspx.cs"
     EnableEventValidation="false" Inherits="BaoCao_F203_BCDVCQThayDoiThongTinTaiSanKhac" %>

<%@ Register Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35"
    TagPrefix="asp" %>
<%@ Register assembly="eWorld.UI" namespace="eWorld.UI" tagprefix="ew" %>
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
                            <span class="cssPageTitle">BÁO CÁO THAY ĐỔI THÔNG TIN TÀI SẢN KHÁC </span>
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
                            &nbsp;<span class="cssManField">Loại hình đơn vị:</span>
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
                            <span class="cssManField">Trạng thái: </span>
                        </td>
                        <td>
                            <asp:DropDownList ID="m_cbo_trang_thai" runat="Server" TabIndex="4" Width="90%">
                            </asp:DropDownList>
                        </td>
                        <td align="right">
                            <span class="cssManField">&nbsp;</span>
                        </td>
                        <td>
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="cssManField">Từ ngày:</span>
                        </td>
                        <td>
                            <ew:CalendarPopup ID="m_dat_tu_ngay" runat="server" 
                                ControlDisplay="TextBoxImage" Culture="vi-VN" DisableTextboxEntry="true" 
                                GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif" ShowGoToToday="true">
                                <WeekdayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <WeekendStyle BackColor="LightGray" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <OffMonthStyle BackColor="AntiqueWhite" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Gray" />
                                <SelectedDateStyle BackColor="#007ccf" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                                <MonthHeaderStyle BackColor="#007ccf" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                                <DayHeaderStyle BackColor="AliceBlue" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                                <ClearDateStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <GoToTodayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <TodayDayStyle BackColor="CadetBlue" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                            </ew:CalendarPopup>
                        </td>
                        <td align="right">
                            <span class="cssManField">Đến ngày: </span>
                        </td>
                        <td>
                            <ew:CalendarPopup ID="m_dat_den_ngay" runat="server" 
                                ControlDisplay="TextBoxImage" Culture="vi-VN" DisableTextboxEntry="true" 
                                GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif" ShowGoToToday="true">
                                <WeekdayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <WeekendStyle BackColor="LightGray" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <OffMonthStyle BackColor="AntiqueWhite" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Gray" />
                                <SelectedDateStyle BackColor="#007ccf" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                                <MonthHeaderStyle BackColor="#007ccf" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                                <DayHeaderStyle BackColor="AliceBlue" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                                <ClearDateStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <GoToTodayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" 
                                    Font-Size="XX-Small" ForeColor="Black" />
                                <TodayDayStyle BackColor="CadetBlue" 
                                    Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small" 
                                    ForeColor="Black" />
                            </ew:CalendarPopup>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <span class="cssManField">Tìm kiếm:</span>
                        </td>
                        <td valign="top" colspan="2">
                            <asp:TextBox ID="m_txt_tim_kiem" runat="Server" Width="95%" CssClass="cssTextBox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td colspan="2" align="left">
                            <asp:Button ID="m_cmd_tim_kiem" AccessKey="l" CssClass="cssButton" runat="server"
                                Width="98px" Text="Lọc dữ liệu(l)" OnClick="m_cmd_tim_kiem_Click" />&nbsp;
                            <asp:Button ID="m_cmd_xuat_excel" AccessKey="x" CssClass="cssButton" runat="server"
                                Width="98px" Text="Xuất Excel (x)" OnClick="m_cmd_xuat_excel_Click" />&nbsp;
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                    <tr>
                        <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_title" runat="server" Text="THÔNG TIN THAY ĐỔI" CssClass="cssPageTitle"></asp:Label><span class="expand-collapse-text initial-expand">
                            </span><span class="expand-collapse-text"></span>
                        </td>
                    </tr>
                    <tr>
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
                            <asp:GridView ID="m_grv_tai_san_khac_history" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                Width="100%" DataKeyNames="ID" CellPadding="4" ForeColor="#333333" AllowSorting="True"
                                EmptyDataText="Không có dữ liệu phù hợp" PageSize="15" ShowHeader="true" OnPageIndexChanging="m_grv_tai_san_khac_history_PageIndexChanging">
                                <AlternatingRowStyle BackColor="White" />
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#810c15" Font-Bold="True" ForeColor="White" />
                                <PagerSettings Position="TopAndBottom" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle CssClass="cssSelectedRow" BackColor="#C5BBAF" Font-Bold="True"
                                    ForeColor="#333333"></SelectedRowStyle>
                                <Columns>
                                <asp:TemplateField HeaderStyle-Width="2%" ItemStyle-HorizontalAlign="center" HeaderText="STT">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                    <asp:BoundField HeaderText="NGÀY CẬP NHẬT CUỐI" DataField="NGAY_CAP_NHAT_CUOI" ItemStyle-HorizontalAlign="right" />
                                    <asp:BoundField HeaderText="LỊCH SỬ CẬP NHẬT" DataField="GHI_CHU_LICH_SU" ItemStyle-HorizontalAlign="left" />
                                    <asp:BoundField HeaderText="ĐƠN VỊ THAY ĐỔI" DataField="USER_GROUP_NAME" />
                                    <asp:BoundField HeaderText="ĐƠN VỊ BỘ TỈNH" DataField="TEN_DV_BO_TINH" />
                                    <asp:BoundField HeaderText="ĐƠN VỊ CHỦ QUẢN" DataField="TEN_DV_CHU_QUAN" />
                                    <asp:BoundField HeaderText="ĐƠN VỊ SỬ DỤNG" DataField="TEN_DV_SU_DUNG" />
                                    <asp:BoundField HeaderText="TRẠNG THÁI" DataField="TEN_TRANG_THAI" />
                                    <asp:BoundField HeaderText="TÊN TÀI SẢN" DataField="TEN_TAI_SAN" />
                                    <asp:BoundField HeaderText="MÃ TÀI SẢN" DataField="MA_TAI_SAN" />
                                    <asp:BoundField HeaderText="KÝ HIỆU" DataField="KY_HIEU" />
                                    <asp:BoundField HeaderText="NƯỚC SẢN XUẤT" DataField="NUOC_SAN_XUAT" />
                                    <asp:BoundField HeaderText="NĂM SỬ DỤNG" DataField="NAM_SU_DUNG" />
                                    <asp:BoundField HeaderText="NĂM SẢN XUẤT" DataField="NAM_SAN_XUAT" />
                                    <asp:BoundField HeaderText="NGUỒN NGÂN SÁCH <br/> (ngàn đồng)" HtmlEncode="false" DataField="NGUON_NS"
                                        ItemStyle-HorizontalAlign="Right" DataFormatString="{0:#,###}" />
                                    <asp:BoundField HeaderText="NGUỒN KHÁC <br/> (ngàn đồng)" HtmlEncode="false" DataField="NGUON_KHAC"
                                        ItemStyle-HorizontalAlign="Right" DataFormatString="{0:#,###}" />
                                    <asp:BoundField HeaderText="GIÁ TRỊ CÒN LẠI <br/> (ngàn đồng)" HtmlEncode="false" DataField="GIA_TRI_CON_LAI"
                                        ItemStyle-HorizontalAlign="Right" DataFormatString="{0:#,###}" />
                                    <asp:BoundField HeaderText="QUẢN LÝ NHÀ NƯỚC" DataField="QLNN" />
                                    <asp:BoundField HeaderText="KINH DOANH" DataField="KINH_DOANH" />
                                    <asp:BoundField HeaderText="KHÔNG KINH DOANH" DataField="KHONG_KINH_DOANH" />
                                    <asp:BoundField HeaderText="KHÁC" DataField="HD_KHAC" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
                                        <triggers>
<asp:PostBackTrigger ControlID="m_cmd_xuat_excel" />
</triggers>
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
