﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;


using System.Collections;


using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace QltsForm
{
    public partial class f100_menu : Form
    {
        public f100_menu()
        {
            InitializeComponent();
        }


        #region public Interface

        public void display() {
            this.ShowDialog();
        }
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion
        #region Data Structures

        #endregion

        #region Members

        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        #endregion

        private void kêKhaiÔTôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f400_bao_cao_danh_muc_o_to v_frm400 = new f400_bao_cao_danh_muc_o_to();
                v_frm400.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void kêKhaiTrụSởLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f402_tao_bao_cao_danh_muc_tru_so_lam_viec v_frm402 = new f402_tao_bao_cao_danh_muc_tru_so_lam_viec();
                v_frm402.display();
                //    f399_bao_cao_danh_muc_tru_so_lam_viec v_frm = new f399_bao_cao_danh_muc_tru_so_lam_viec();
                //    v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void kêKhaiTàiSảnKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f401_bao_cao_danh_muc_tai_san_khac v_frm401 = new f401_bao_cao_danh_muc_tai_san_khac();
                v_frm401.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void tHTHSDNhàĐấtChiTiếtTheoLoạiHìnhĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f320_RPT_TONG_HOP_HIEN_TRANG v_frm = new f320_RPT_TONG_HOP_HIEN_TRANG();
                v_frm.display();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void kêKhaiTrụSởLàmViệcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                f402_tao_bao_cao_danh_muc_tru_so_lam_viec v_frm402 = new f402_tao_bao_cao_danh_muc_tru_so_lam_viec();
                v_frm402.display();
                //    f399_bao_cao_danh_muc_tru_so_lam_viec v_frm = new f399_bao_cao_danh_muc_tru_so_lam_viec();
                //    v_frm.display();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void kêKhaiÔTôToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F403_tao_bao_cao_danh_muc_oto v_frm = new F403_tao_bao_cao_danh_muc_oto();
            v_frm.display();
        }

        private void đềNghịXửLýTàiSảnKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đềNghịXửLýTrụSởLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f402_tao_bao_cao_danh_muc_tru_so_lam_viec v_frm = new f402_tao_bao_cao_danh_muc_tru_so_lam_viec();
                v_frm.set_form_mode(f402_tao_bao_cao_danh_muc_tru_so_lam_viec.eFormMode.DE_NGHI_XU_LY);
                v_frm.display();
            }
            catch (Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void đềNghịXửLýÔTôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                F403_tao_bao_cao_danh_muc_oto v_frm = new F403_tao_bao_cao_danh_muc_oto();
                v_frm.set_form_mode(F403_tao_bao_cao_danh_muc_oto.eFormMode.DE_NGHI_XU_LY);
                v_frm.display();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void tổngHợpChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f404_tao_bao_cao_thsd_nha_dat v_frm = new f404_tao_bao_cao_thsd_nha_dat();
                v_frm.display();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }
    }
}
