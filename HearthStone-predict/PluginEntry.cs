using System;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Plugins;

namespace HearthStone_predict
{
    public class PluginEntry : IPlugin
    {
        public void OnLoad()
        {
            
        }

        public void OnUnload()
        {
        }

        public void OnButtonPress()
        {
        }

        public void OnUpdate()
        {
        }

        public string Name { get; } = "Predict";
        public string Description { get; } = "用于预测酒馆中使用卡牌赢面较大的";
        public string ButtonText { get; } = "predict";
        public string Author { get; } = "yhh";
        public Version Version { get; } = new Version(1, 0, 0);
        public System.Windows.Controls.MenuItem MenuItem { get; } = new MenuItem() {Header = "predict"};
    }
}
