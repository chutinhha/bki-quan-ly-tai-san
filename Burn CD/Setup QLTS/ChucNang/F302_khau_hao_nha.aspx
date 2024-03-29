﻿<%@ page title="" language="C#" masterpagefile="~/Site.master" autoeventwireup="true" enableeventvalidation="false" inherits="ChucNang_F302_khau_hao_nha, App_Web_pnkqqndn" %>

<%@ Register Assembly="System.Web.Extensions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <script type="text/javascript">
        $(function () {
            $(".tb").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "../ChucNang/PersonService.asmx/GetNha",
                        data: "{ 'name_prefix': '" + request.term + "', 'ip_dc_id_dat': '"
                        + document.getElementById('<%= m_cbo_thuoc_khu_dat.ClientID%>').value + "' }",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        dataFilter: function (data) { return data; },
                        success: function (data) {
                            response($.map(data.d, function (item) {
                                return {
                                    value: item.strTEN_TAI_SAN,
                                    dcID: item.dcID
                                }
                            }))
                        },
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            alert(textStatus);
                        }
                    });
                },
                minLength: 1,
                select: function (event, ui) {
                    document.getElementById("<%= m_hdf_id.ClientID%>").value = ui.item.dcID;
                    console.log(ui.item.dcID);
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table border="0" cellspacing="0" cellpadding="0" width="100%">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <span class="cssPageTitle">HAO MÒN TÀI SẢN NHÀ</span> <span class="expand-collapse-text initial-expand">
                        </span><span class="expand-collapse-text"></span>
                    </td>
                </tr>
                <tr>
                    <td colspan="6">
                        <asp:ValidationSummary ID="vdsCategory" runat="server" CssClass="cssManField" Font-Bold="true"
                            ValidationGroup="m_vlg_nha" />
                        <asp:Label ID="m_lbl_mess" runat="server" CssClass="cssManField" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                            <tr>
                                <td align="right" style="width: 20%">
                                    <span class="cssManField">Bộ, tỉnh</span>
                                </td>
                                <td style="width: 29%" align="left">
                                    <asp:DropDownList ID="m_cbo_bo_tinh_up" runat="server" Width="85%" ValidationGroup="m_vlg_nha"
                                        AutoPostBack="True" OnSelectedIndexChanged="m_cbo_bo_tinh_up_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 1%">
                                </td>
                                <td align="right" style="width: 20%">
                                    <span class="cssManField">Đơn vị chủ quản</span>
                                </td>
                                <td align="left" style="width: 29%;">
                                    <asp:DropDownList ID="m_cbo_don_vi_chu_quan_up" runat="server" Width="85%" ValidationGroup="m_vlg_nha"
                                        AutoPostBack="True" OnSelectedIndexChanged="m_cbo_don_vi_chu_quan_up_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td style="width: 1%">
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <span class="cssManField">Đơn vị sử dụng</span>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="m_cbo_don_vi_su_dung_up" runat="server" Width="85%" ValidationGroup="m_vlg_nha"
                                        AutoPostBack="True" OnSelectedIndexChanged="m_cbo_don_vi_su_dung_up_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                </td>
                                <td align="right">
                                    <span class="cssManField">Trạng thái nhà</span>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="m_cbo_trang_thai_nha_up" runat="server" Width="85%" ValidationGroup="m_vlg_nha"
                                        Enabled="false">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <span class="cssManField">Địa chỉ</span>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="m_cbo_thuoc_khu_dat" runat="server" Width="85%" ValidationGroup="m_vlg_nha"
                                        AutoPostBack="true" OnSelectedIndexChanged="m_cbo_thuoc_khu_dat_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                </td>
                                <td align="right">
                                    <span class="cssManField">Tên tài sản</span>
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="m_cbo_ten_tai_san" runat="server" Width="85%" OnSelectedIndexChanged="m_cbo_ten_tai_san_SelectedIndexChanged"
                                        AutoPostBack="true">
                                    </asp:DropDownList>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <span class="cssManField">Tên tài sản</span>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_ten_tai_san" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td>
                                </td>
                                <td align="right">
                                    <span class="cssManField">Mã tài sản</span>
                                </td>
                                <td>
                                    <asp:Label ID="m_lbl_ma_tai_san" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%">
                                    <span class="cssManField">Cấp hạng</span>
                                </td>
                                <td>
                                    <asp:Label ID="m_lbl_cap_hang" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td>
                                </td>
                                <td align="right">
                                    <span class="cssManField">Năm xây dựng</span>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_nam_xay_dung" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 20%">
                                    <span class="cssManField">Năm sử dụng</span>
                                </td>
                                <td style="width: 29%" align="left">
                                    <asp:Label ID="m_lbl_ngay_thang_nam_du_dung" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td align="right" style="width: 1%">
                                </td>
                                <td align="left" style="width: 20%;">
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" align="center" class="cssManField">
                                    <span>GIÁ TRỊ THEO SỔ KẾ TOÁN</span>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 15%">
                                    <span class="cssManField">Nguyên giá nguồn NS (ngàn đồng)</span>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_nguyen_gia_nguon_ns" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td>
                                </td>
                                <td align="right">
                                    <span class="cssManField">Nguyên giá nguồn khác (ngàn đồng)</span>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_nguyen_gia_nguon_khac" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <span class="cssManField">Giá trị còn lại (ngàn đồng)</span>
                                </td>
                                <td align="left">
                                    <asp:Label ID="m_lbl_gia_tri_con_lai" runat="Server" class="cssManField" Style="color: blue">
                                    </asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td class="cssManField" colspan="2" align="center">
                                    <span>CHI TIẾT HAO MÒN TÀI SẢN</span>
                                </td>
                            </tr>
                            <tr>
                                <td class="cssManField" align="right" colspan="1" style="width: 20%">
                                    <span>Mã phiếu *</span>
                                </td>
                                <td colspan="1" style="width: 29%">
                                    <asp:TextBox ID="m_txt_ma_phieu" runat="server" CssClass="cssTextBox" Width="85%"
                                        ValidationGroup="m_vlg_nha">
                                    </asp:TextBox>
                                </td>
                                <td align="left" style="width: 1%;">
                                    <asp:RequiredFieldValidator ID="m_rfv_ma_phieu" runat="server" ControlToValidate="m_txt_ma_phieu"
                                        ErrorMessage="Bạn phải nhập Mã Phiếu" Text="*" ValidationGroup="m_vlg_nha" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </td>
                                <td colspan="1" style="width: 20%" align="right" class="cssManField">
                                    <span>Giá trị hao mòn *</span>
                                </td>
                                <td>
                                    <asp:TextBox ID="m_txt_gia_tri_khau_hao" runat="server" CssClass="cssTextBox csscurrency"
                                        Width="85%" ValidationGroup="m_vlg_nha">
                                    </asp:TextBox>
                                </td>
                                <td align="left" style="width: 1%;">
                                    <asp:RequiredFieldValidator ID="m_rfv_gia_tri_khau_hao" runat="server" ControlToValidate="m_txt_gia_tri_khau_hao"
                                        ErrorMessage="Bạn phải nhập Giá Trị hao mòn" Text="*" ValidationGroup="m_vlg_nha"
                                        ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="1" align="right" class="cssManField">
                                    <span>Ngày lập </span>
                                </td>
                                <td style="width: 29%" align="left">
                                    <ew:CalendarPopup ID="m_dat_ngay_lap" runat="server" ControlDisplay="TextBoxImage"
                                        Culture="vi-VN" DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                                        ShowGoToToday="true">
                                        <WeekdayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <WeekendStyle BackColor="LightGray" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <OffMonthStyle BackColor="AntiqueWhite" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Gray" />
                                        <SelectedDateStyle BackColor="#007ccf" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                        <MonthHeaderStyle BackColor="#007ccf" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                        <DayHeaderStyle BackColor="AliceBlue" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                        <ClearDateStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <GoToTodayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <TodayDayStyle BackColor="CadetBlue" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                    </ew:CalendarPopup>
                                </td>
                                <td align="left" style="width: 1%">
                                </td>
                                <td align="right" class="cssManField">
                                    <span>Ngày duyệt </span>
                                </td>
                                <td style="width: 29%" align="left">
                                    <ew:CalendarPopup ID="m_dat_ngay_duyet" runat="server" ControlDisplay="TextBoxImage"
                                        Culture="vi-VN" DisableTextBoxEntry="true" GoToTodayText="Hôm nay: " ImageUrl="~/Images/cal.gif"
                                        ShowGoToToday="true">
                                        <WeekdayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <WeekendStyle BackColor="LightGray" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <OffMonthStyle BackColor="AntiqueWhite" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Gray" />
                                        <SelectedDateStyle BackColor="#007ccf" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                        <MonthHeaderStyle BackColor="#007ccf" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                        <DayHeaderStyle BackColor="AliceBlue" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                        <ClearDateStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <GoToTodayStyle BackColor="White" Font-Names="Verdana,Helvetica,Tahoma,Arial" Font-Size="XX-Small"
                                            ForeColor="Black" />
                                        <TodayDayStyle BackColor="CadetBlue" Font-Names="Verdana,Helvetica,Tahoma,Arial"
                                            Font-Size="XX-Small" ForeColor="Black" />
                                    </ew:CalendarPopup>
                                </td>
                                <td align="left" style="width: 1%;">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td colspan="4" align="center">
                                    <asp:Button ID="m_cmd_tao_moi" AccessKey="c" CssClass="cssButton" runat="server"
                                        Height="24px" Width="98px" Text="Tạo mới(c)" ValidationGroup="m_vlg_nha" OnClick="m_cmd_tao_moi_Click" />
                                    <asp:Button ID="m_cmd_xoa_trang" AccessKey="r" CssClass="cssButton" runat="server"
                                        Height="24px" Width="98px" Text="Xóa trắng(r)" OnClick="m_cmd_xoa_trang_Click" />
                                    <asp:HiddenField ID="m_hdf_id" runat="server" Value="" />
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table cellspacing="0" cellpadding="2" style="width: 100%;" class="cssTable" border="0">
                <tr>
                    <td class="cssPageTitleBG" colspan="6">
                        <asp:Label ID="m_lbl_danh_sach_khau_hao_nha" runat="Server" class="cssPageTitle"
                            Text="DANH SÁCH CÁC LẦN HAO MÒN TÀI SẢN NHÀ"></asp:Label>
                        <span class="expand-collapse-text initial-expand"></span><span class="expand-collapse-text">
                        </span>
                    </td>
                </tr>
                <tr>
                    <td align="right" colspan="1" style="width: 20%">
                        <span class="cssManField">Bộ, tỉnh </span>
                    </td>
                    <td style="width: 30%" colspan="1">
                        <asp:DropDownList ID="m_cbo_bo_tinh_down" Width="85%" runat="Server" AutoPostBack="True"
                            TabIndex="1" OnSelectedIndexChanged="m_cbo_bo_tinh_down_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td align="right" style="width: 20%" colspan="1">
                        <span class="cssManField">Đơn vị chủ quản </span>
                    </td>
                    <td style="width: 30%" colspan="1">
                        <asp:DropDownList ID="m_cbo_don_vi_chu_quan_down" Width="85%" runat="Server" AutoPostBack="True"
                            TabIndex="2" OnSelectedIndexChanged="m_cbo_don_vi_chu_quan_down_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <span class="cssManField">Đơn vị sử dụng tài sản </span>
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_don_vi_su_dung_down" Width="85%" runat="Server" AutoPostBack="True"
                            TabIndex="3" OnSelectedIndexChanged="m_cbo_don_vi_su_dung_down_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td align="right">
                        <span class="cssManField">Địa chỉ</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="m_cbo_dia_chi" runat="Server" Width="85%" TabIndex="4" AutoPostBack="true"
                            OnSelectedIndexChanged="m_cbo_dia_chi_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" colspan="1" style="width: 20%">
                        <span class="cssManField">Từ khóa </span>
                    </td>
                    <td style="width: 30%" colspan="1">
                        <asp:TextBox ID="m_txt_tu_khoa" runat="server" CssClass="cssTextBox" AutoPostBack="true"
                            Width="85%" OnTextChanged="m_txt_tu_khoa_TextChanged">
                        </asp:TextBox>
                    </td>
                    <td align="right" style="width: 20%" colspan="1">
                    </td>
                    <td style="width: 30%" colspan="1">
                    </td>
                </tr>
                <tr>
                    <td align="right">
                    </td>
                    <td align="left">
                        <asp:Button ID="m_cmd_tim_kiem" runat="server" AccessKey="s" CssClass="cssButton"
                            Height="24px" Text="Tìm kiếm" Width="98px" OnClick="m_cmd_tim_kiem_Click" CausesValidation="false" />
                        <asp:Button ID="m_cmd_xuat_excel" runat="server" CausesValidation="False" CssClass="cssButton"
                            Height="25px" Text="Xuất Excel" Width="98px" OnClick="m_cmd_xuat_excel_Click"  />
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="left" colspan="2">
                        <asp:Label ID="m_lbl_thong_bao" Visible="false" runat="server" CssClass="cssManField" />
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="4" style="height: 450px;" valign="top">
                        <asp:GridView ID="m_grv_danh_sach_nha" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                            Width="100%" DataKeyNames="ID_KH" CellPadding="0" ForeColor="#333333" AllowSorting="True"
                            CssClass="cssGrid" EmptyDataText="Không có dữ liệu phù hợp" PageSize="30" ShowHeader="true"
                            OnPageIndexChanging="m_grv_danh_sach_nha_PageIndexChanging" OnRowCommand="m_grv_danh_sach_nha_RowCommand">
                            <Columns>
                                <asp:TemplateField HeaderText="Xóa" ItemStyle-Width="2%">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="m_lbt_delete" runat="server" CommandName="DeleteComp" ToolTip="Xóa"
                                            OnClientClick="return confirm ('Bạn có thực sự muốn xóa bản ghi này?')" CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'>
                                    <img src="../Images/Button/deletered.png" alt="Delete" />
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Mã phiếu" DataField="MA_PHIEU" />
                                <asp:BoundField HeaderText="Tên tài sản" DataField="TEN_TAI_SAN" />
                                <asp:BoundField HeaderText="Đơn vị sử dụng" DataField="TEN_DV_SU_DUNG" />
                                <asp:BoundField HeaderText="Địa chỉ" DataField="DIA_CHI" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Cấp hạng" DataField="CAP_HANG" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Năm xây dựng" DataField="NAM_XAY_DUNG" ItemStyle-HorizontalAlign="Center" />
                                <asp:BoundField HeaderText="Năm sử dụng" DataField="NGAY_THANG_NAM_SU_DUNG" ItemStyle-HorizontalAlign="Center" />
                                <asp:TemplateField HeaderStyle-Width="25%" HeaderStyle-Height="110px">
                                    <HeaderTemplate>
                                        <table border="1" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;">
                                            <tr>
                                                <td colspan="3" style="height: 50px">
                                                    GIÁ TRỊ THEO SỔ KẾ TOÁN
                                                    <br />
                                                    (ngàn đồng)
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    Nguyên giá
                                                </td>
                                                <td rowspan="2" style="width: 33%; height: 60px">
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
                                        <table border="0" cellspacing="0" cellpadding="2" width="100%" style="border-collapse: collapse;
                                            text-align: right">
                                            <td style="width: 33%; height: 60px; border-right: 1px solid gray; text-align: right">
                                                <%# Eval("NGUON_NS", "{0:#,##0}")%>
                                            </td>
                                            <td style="width: 33%; height: 60px; border-right: 1px solid gray; text-align: right">
                                                <%# Eval("NGUON_KHAC", "{0:#,##0}")%>
                                            </td>
                                            <td style="width: 33%; height: 60px; text-align: right">
                                                <%# Eval("GIA_TRI_CON_LAI", "{0:#,##0}")%>
                                            </td>
                                        </table>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Giá trị hao mòn" DataField="GIA_TRI_KHAU_HAO" DataFormatString="{0:#,##0}"
                                    ItemStyle-HorizontalAlign="Right" />
                                <asp:BoundField HeaderText="Ngày lập" DataField="NGAY_LAP" />
                                <asp:BoundField HeaderText="Ngày duyệt" DataField="NGAY_DUYET" />
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
</asp:Content>
