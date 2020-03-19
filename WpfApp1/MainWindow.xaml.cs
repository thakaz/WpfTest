using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 時刻表示用のタイマーです
        /// </summary>
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            //タイマー生成
            timer = CreateTimer();
        }
    
        /// <summary>
        /// タイマー生成処理
        /// </summary>
        /// <returns>生成したタイマー</returns>
        private DispatcherTimer CreateTimer()
        {
            // タイマー生成 (優先度はアイドルに設定)
            var t = new DispatcherTimer(DispatcherPriority.SystemIdle);
            //タイマーイベントの発生感覚を300ミリ秒に設定
            t.Interval = TimeSpan.FromMilliseconds(300);
            //タイマーイベントの定義
            t.Tick += (sender, e) =>
            {
                //タイマーイベント発生時の処理をここに書く
                //現在の時分秒をテキストに表示
                textBlock.Text = DateTime.Now.ToString("HH:mm:ss");

            };
            
            return t;


        }

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //タイマー開始
            timer.Start();
        }
    }
}
