﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="F306_TH_tang_giam_tai_san_Chi_tiet_theo_tung_don_vi.aspx.cs" Inherits="BaoCao_F303_TH_tang_giam_tai_san_Chi__tiet_theo_tung_don_vi" %>

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
                <table border="0" cellspacing="0" cellpadding="0" width="100%" class="cssTable">
                    <tr>
                        <td class="cssPageTitleBG" colspan="6">
                            <span class="cssPageTitle">TỔNG HỢP TÌNH HÌNH TĂNG, GIẢM TÀI SẢN NHÀ NƯỚC</span>
                            <span class="expand-collapse-text"></span>
                            <br />
                            <span class="cssPageTitle">Phần 3: Chi tiết theo từng đơn vị</span><span class="expand-collapse-text initial-expand"></span>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="6">
                            <asp:ValidationSummary ID="vdsCategory" runat="server" CssClass="cssManField" Font-Bold="true"
                                ValidationGroup="m_vlg_tai_san" />
                            <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right" colspan="1" style="width: 15%">
                            <span class="cssManField">Bộ, tỉnh:</span>
                        </td>
                        <td style="width: 34%">
                            <asp:DropDownList ID="m_cbo_bo_tinh" Width="90%" runat="Server" AutoPostBack="True"
                                TabIndex="1" OnSelectedIndexChanged="m_cbo_bo_tinh_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 1%">
                        </td>
                        <td align="right" style="width: 15%">
                            <span class="cssManField">Đơn vị chủ quản:</span>
                        </td>
                        <td style="width: 34%">
                            <asp:DropDownList ID="m_cbo_don_vi_chu_quan" Width="90%" runat="Server" TabIndex="2">
                            </asp:DropDownList>
                        </td>
                        <td style="width: 1%">
                        </td>
                    </tr>
                    <tr>
                        <td class="cssManField" align="right">
                            <span>Từ ngày:</span>
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
                        <td>
                            &nbsp;</td>
                        <td class="cssManField" align="right">
                            <span>Đến ngày:</span>
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
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td align="left">
                            <asp:Button ID="m_cmd_loc_du_lieu" AccessKey="l" CssClass="cssButton" runat="server"
                                Width="98px" Text="Lọc dữ liệu(l)" Height="23px" TabIndex="5" OnClick="m_cmd_loc_du_lieu_Click" />
                            <asp:Button ID="m_cmd_xuat_excel" AccessKey="x" CssClass="cssButton" runat="server"
                                Width="98px" Text="Xuất Excel (x)" Height="22px" OnClick="m_cmd_xuat_excel_Click" />
                        </td>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
                <table border="0" cellspacing="0" cellpadding="0" width="100%" class="cssTable">
                    <tr style="width: 100%">
                        <td class="cssPageTitleBG" colspan="3">
                            <span class="cssPageTitle">DANH SÁCH CHI TIẾT TÀI SẢN</span> <span class="expand-collapse-text initial-expand">
                            </span><span class="expand-collapse-text"></span>
                        </td>
                    </tr>
                    <tr>
                        <td class="cssManField">
                            <asp:Label ID="m_lbl_thong_bao" runat="Server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="12">
                            <asp:GridView ID="m_grv_tai_san" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                EmptyDataText="Không có dữ liệu phù hợp!" Width="100%" DataKeyNames="ID" CellPadding="0"
                                ForeColor="#333333" AllowSorting="True" PageSize="10">
                                 <Columns>
                                    <asp:HyperLinkField HeaderText="TÀI SẢN" HeaderStyle-Width="20%" DataTextField="TAI_SAN"
                                        NavigateUrl="" />
                                    <asp:TemplateField HeaderStyle-Width="20%" HeaderStyle-Height="75px">
                                        <HeaderTemplate>
                                            <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse">
                                                <tr>
                                                    <td colspan="3" style="height: 45px; text-align: center; color: white; font-weight:bold">
                                                        SỐ ĐẦU KỲ
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1" style="width: 30%; height: 30px; text-align: center; color: white; font-weight:bold">
                                                        Số lượng
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 30%;; text-align: center; color: white; font-weight:bold">
                                                        Diện tích
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 40%;; text-align: center; color: white; font-weight:bold">
                                                        Nguyên giá
                                                    </td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                                <tr>
                                                    <td style="width: 30%; border-right: 1px solid gray; height: 45px" align="right">
                                                        <%# Eval("SO_DAU_KY_SO_LUONG")%>
                                                    </td>
                                                    <td style="width: 30%; border-right: 1px solid gray" align="right">
                                                        <%# Eval("SO_DAU_KY_DIEN_TICH", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 40%;" align="right">
                                                        <%# Eval("SO_DAU_KY_NGUYEN_GIA", "{0:#,###}")%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderStyle-Width="20%" HeaderStyle-Height="75px">
                                        <HeaderTemplate>
                                            <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse">
                                                <tr>
                                                    <td colspan="3" style="height: 45px; text-align: center; color: white; font-weight:bold">
                                                        SỐ TĂNG TRONG KỲ
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1" style="width: 30%; height: 30px; text-align: center; color: white; font-weight:bold">
                                                        Số lượng
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 30%;; text-align: center; color: white; font-weight:bold">
                                                        Diện tích
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 40%;; text-align: center; color: white; font-weight:bold">
                                                        Nguyên giá
                                                    </td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                                <tr>
                                                    <td style="width: 30%; border-right: 1px solid gray; height: 45px" align="right">
                                                        <%# Eval("SO_TANG_TRONG_KY_SO_LUONG")%>
                                                    </td>
                                                    <td style="width: 30%; border-right: 1px solid gray" align="right">
                                                        <%# Eval("SO_TANG_TRONG_KY_DIEN_TICH", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 40%;" align="right">
                                                        <%# Eval("SO_TANG_TRONG_KY_NGUYEN_GIA", "{0:#,###}")%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderStyle-Width="20%" HeaderStyle-Height="75px">
                                        <HeaderTemplate>
                                            <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse">
                                                <tr>
                                                    <td colspan="3" style="height: 45px; text-align: center; color: white; font-weight:bold">
                                                        SỐ GIẢM TRONG KỲ
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1" style="width: 30%; height: 30px; text-align: center; color: white; font-weight:bold">
                                                        Số lượng
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 30%; text-align: center; color: white; font-weight:bold">
                                                        Diện tích
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 40%; text-align: center; color: white; font-weight:bold">
                                                        Nguyên giá
                                                    </td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                                <tr>
                                                    <td style="width: 30%; border-right: 1px solid gray; height: 45px" align="right">
                                                        <%# Eval("SO_GIAM_TRONG_KY_SO_LUONG")%>
                                                    </td>
                                                    <td style="width: 30%; border-right: 1px solid gray" align="right">
                                                        <%# Eval("SO_GIAM_TRONG_KY_DIEN_TICH", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 40%;" align="right">
                                                        <%# Eval("SO_GIAM_TRONG_KY_NGUYEN_GIA", "{0:#,###}")%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderStyle-Width="20%" HeaderStyle-Height="75px">
                                        <HeaderTemplate>
                                            <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse">
                                                <tr>
                                                    <td colspan="3" style="height: 45px; text-align: center; color: white; font-weight:bold">
                                                        SỐ CUỐI KỲ
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="1" rowspan="1" style="width: 30%; height: 30px; text-align: center; color: white; font-weight:bold">
                                                        Số lượng
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 30%;; text-align: center; color: white; font-weight:bold">
                                                        Diện tích
                                                    </td>
                                                    <td colspan="1" rowspan="1" style="width: 40%;; text-align: center; color: white; font-weight:bold">
                                                        Nguyên giá
                                                    </td>
                                                </tr>
                                            </table>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                                <tr>
                                                    <td style="width: 30%; border-right: 1px solid gray; height: 45px" align="right">
                                                        <%# Eval("SO_CUOI_KY_SO_LUONG")%>
                                                    </td>
                                                    <td style="width: 30%; border-right: 1px solid gray" align="right">
                                                        <%# Eval("SO_CUOI_KY_DIEN_TICH", "{0:#,###}")%>
                                                    </td>
                                                    <td style="width: 40%;" align="right">
                                                        <%# Eval("SO_CUOI_KY_NGUYEN_GIA", "{0:#,###}")%>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="TÊN ĐƠN VỊ BỘ TỈNH">
                                        <ItemTemplate>
                                            <%#get_ten_bo_tinh()%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="TÊN ĐƠN VỊ CHỦ QUẢN">
                                        <ItemTemplate>
                                            <%#get_ten_don_vi_chu_quan()%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="MÃ ĐƠN VỊ CHỦ QUẢN">
                                        <ItemTemplate>
                                            <%#get_ma_don_vi_chu_quan()%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="TỪ NGÀY">
                                        <ItemTemplate>
                                            <%#get_date_tu_ngay()%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="ĐẾN NGÀY">
                                        <ItemTemplate>
                                            <%#get_date_den_ngay()%>
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
