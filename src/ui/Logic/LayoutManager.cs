﻿using System.Drawing;
using Nikse.SubtitleEdit.Controls;
using System.Windows.Forms;

namespace Nikse.SubtitleEdit.Logic
{
    public static class LayoutManager
    {
        public static int ToggleLayout(int layout, Control.ControlCollection controls, Control videoPlayer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            layout++;
            if (layout > 7 || layout < 0)
            {
                layout = 0;
            }

            SetLayout(layout, controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
            return layout;
        }

        public static void SetLayout(int layout, Control.ControlCollection controls, Control videoPlayer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            if (layout > 7 || layout < 0)
            {
                layout = 0;
            }

            switch (layout)
            {
                case 0:
                    SetLayout0(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 1:
                    SetLayout1(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 2:
                    SetLayout2(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 3:
                    SetLayout3(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 4:
                    SetLayout4(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 5:
                    SetLayout5(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 6:
                    SetLayout6(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
                case 7:
                    SetLayout7(controls, videoPlayer, subtitleListView, groupBoxWaveform, groupBoxEdit);
                    break;
            }
        }

        public static void SetLayout0(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Horizontal;

            groupBoxWaveform.Parent.Controls.Remove(groupBoxWaveform);
            spMain.Panel2.Controls.Add(groupBoxWaveform);
            groupBoxWaveform.Dock = DockStyle.Fill;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Vertical;
            spMain.Panel1.Controls.Add(spLeftTop);
            spLeftTop.Dock = DockStyle.Fill;

            videoPlayerContainer.Parent.Controls.Remove(videoPlayerContainer);
            spLeftTop.Panel2.Controls.Add(videoPlayerContainer);
            videoPlayerContainer.Dock = DockStyle.Fill;

            var spLeftBottom = new SplitContainer();
            spLeftBottom.Orientation = Orientation.Horizontal;
            spLeftTop.Panel1.Controls.Add(spLeftBottom);
            spLeftBottom.Dock = DockStyle.Fill;

            subtitleListView.Parent.Controls.Remove(subtitleListView);
            spLeftBottom.Panel1.Controls.Add(subtitleListView);
            subtitleListView.Dock = DockStyle.Fill;

            groupBoxEdit.Parent.Controls.Remove(groupBoxEdit);
            spLeftBottom.Panel2.Controls.Add(groupBoxEdit);
            groupBoxEdit.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        public static void SetLayout1(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Horizontal;

            groupBoxWaveform.Parent.Controls.Remove(groupBoxWaveform);
            spMain.Panel2.Controls.Add(groupBoxWaveform);
            groupBoxWaveform.Dock = DockStyle.Fill;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Vertical;
            spMain.Panel1.Controls.Add(spLeftTop);
            spLeftTop.Dock = DockStyle.Fill;

            videoPlayerContainer.Parent.Controls.Remove(videoPlayerContainer);
            spLeftTop.Panel1.Controls.Add(videoPlayerContainer);
            videoPlayerContainer.Dock = DockStyle.Fill;

            var spLeftBottom = new SplitContainer();
            spLeftBottom.Orientation = Orientation.Horizontal;
            spLeftTop.Panel2.Controls.Add(spLeftBottom);
            spLeftBottom.Dock = DockStyle.Fill;

            subtitleListView.Parent.Controls.Remove(subtitleListView);
            spLeftBottom.Panel1.Controls.Add(subtitleListView);
            subtitleListView.Dock = DockStyle.Fill;

            groupBoxEdit.Parent.Controls.Remove(groupBoxEdit);
            spLeftBottom.Panel2.Controls.Add(groupBoxEdit);
            groupBoxEdit.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        public static void SetLayout2(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Vertical;

            videoPlayerContainer.Parent.Controls.Remove(videoPlayerContainer);
            spMain.Panel2.Controls.Add(videoPlayerContainer);
            videoPlayerContainer.Dock = DockStyle.Fill;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Horizontal;
            spMain.Panel1.Controls.Add(spLeftTop);
            spLeftTop.Dock = DockStyle.Fill;
            var lv = subtitleListView;
            lv.Parent.Controls.Remove(lv);
            spLeftTop.Panel1.Controls.Add(lv);
            lv.Dock = DockStyle.Fill;

            var spLeftBottom = new SplitContainer();
            spLeftBottom.Orientation = Orientation.Horizontal;
            spLeftTop.Panel2.Controls.Add(spLeftBottom);
            spLeftBottom.Dock = DockStyle.Fill;

            var ge = groupBoxEdit;
            ge.Parent.Controls.Remove(ge);
            spLeftBottom.Panel1.Controls.Add(ge);
            ge.Dock = DockStyle.Fill;

            var gv = groupBoxWaveform;
            gv.Parent.Controls.Remove(gv);
            spLeftBottom.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        public static void SetLayout3(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Vertical;

            videoPlayerContainer.Parent.Controls.Remove(videoPlayerContainer);
            spMain.Panel1.Controls.Add(videoPlayerContainer);
            videoPlayerContainer.Dock = DockStyle.Fill;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Horizontal;
            spMain.Panel2.Controls.Add(spLeftTop);
            spLeftTop.Dock = DockStyle.Fill;
            var lv = subtitleListView;
            lv.Parent.Controls.Remove(lv);
            spLeftTop.Panel1.Controls.Add(lv);
            lv.Dock = DockStyle.Fill;

            var spLeftBottom = new SplitContainer();
            spLeftBottom.Orientation = Orientation.Horizontal;
            spLeftTop.Panel2.Controls.Add(spLeftBottom);
            spLeftBottom.Dock = DockStyle.Fill;

            var ge = groupBoxEdit;
            ge.Parent.Controls.Remove(ge);
            spLeftBottom.Panel1.Controls.Add(ge);
            ge.Dock = DockStyle.Fill;

            var gv = groupBoxWaveform;
            gv.Parent.Controls.Remove(gv);
            spLeftBottom.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        public static void SetLayout4(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Horizontal;

            videoPlayerContainer.Parent.Controls.Remove(videoPlayerContainer);
            spMain.Panel1.Controls.Add(videoPlayerContainer);
            videoPlayerContainer.Dock = DockStyle.Fill;
            spMain.SplitterDistance = 20;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Horizontal;
            spMain.Panel2.Controls.Add(spLeftTop);
            spLeftTop.MinimumSize = new Size(0, 0);
            spLeftTop.Dock = DockStyle.Fill;
            var lv = subtitleListView;
            lv.Parent.Controls.Remove(lv);
            spLeftTop.Panel1.Controls.Add(lv);
            lv.Dock = DockStyle.Fill;

            var spLeftBottom = new SplitContainer();
            spLeftBottom.Orientation = Orientation.Horizontal;
            spLeftTop.Panel2.Controls.Add(spLeftBottom);
            spLeftBottom.MinimumSize = new Size(0, 0);
            spLeftBottom.Dock = DockStyle.Fill;

            var ge = groupBoxEdit;
            ge.Parent.Controls.Remove(ge);
            spLeftBottom.Panel1.Controls.Add(ge);
            ge.Dock = DockStyle.Fill;

            var gv = groupBoxWaveform;
            gv.Parent.Controls.Remove(gv);
            spLeftBottom.Panel2.Controls.Add(gv);
            gv.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        // no video player
        public static void SetLayout5(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Horizontal;

            subtitleListView.Parent.Controls.Remove(subtitleListView);
            spMain.Panel1.Controls.Add(subtitleListView);
            subtitleListView.Dock = DockStyle.Fill;
            spMain.SplitterDistance = 20;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Horizontal;
            spMain.Panel2.Controls.Add(spLeftTop);
            spLeftTop.MinimumSize = new Size(0, 0);
            spLeftTop.Dock = DockStyle.Fill;

            groupBoxEdit.Parent.Controls.Remove(groupBoxEdit);
            spLeftTop.Panel1.Controls.Add(groupBoxEdit);
            groupBoxEdit.Dock = DockStyle.Fill;

            groupBoxWaveform.Parent.Controls.Remove(groupBoxWaveform);
            spLeftTop.Panel2.Controls.Add(groupBoxWaveform);
            groupBoxWaveform.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        // no waveform
        public static void SetLayout6(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Vertical;

            videoPlayerContainer.Parent.Controls.Remove(videoPlayerContainer);
            spMain.Panel2.Controls.Add(videoPlayerContainer);
            videoPlayerContainer.Dock = DockStyle.Fill;

            var spLeftTop = new SplitContainer();
            spLeftTop.Orientation = Orientation.Horizontal;
            spMain.Panel1.Controls.Add(spLeftTop);
            spLeftTop.Dock = DockStyle.Fill;

            subtitleListView.Parent.Controls.Remove(subtitleListView);
            spLeftTop.Panel1.Controls.Add(subtitleListView);
            subtitleListView.Dock = DockStyle.Fill;

            groupBoxEdit.Parent.Controls.Remove(groupBoxEdit);
            spLeftTop.Panel2.Controls.Add(groupBoxEdit);
            groupBoxEdit.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }

        // no video or waveform
        public static void SetLayout7(Control.ControlCollection controls, Control videoPlayerContainer, SubtitleListView subtitleListView, GroupBox groupBoxWaveform, GroupBox groupBoxEdit)
        {
            var spMain = new SplitContainer();
            spMain.Orientation = Orientation.Horizontal;

            subtitleListView.Parent.Controls.Remove(subtitleListView);
            spMain.Panel1.Controls.Add(subtitleListView);
            subtitleListView.Dock = DockStyle.Fill;

            groupBoxEdit.Parent.Controls.Remove(groupBoxEdit);
            spMain.Panel2.Controls.Add(groupBoxEdit);
            groupBoxEdit.Dock = DockStyle.Fill;

            controls.Add(spMain);
            spMain.Dock = DockStyle.Fill;
            spMain.BringToFront();
        }
    }
}
