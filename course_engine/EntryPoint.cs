using System;
using MyEngine.Ecs;
using MyEngine.Gui;


namespace MyEngine
{
    /// <summary>
    /// класс входной точки
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// главна функция программы
        /// </summary>
        /// <returns>таймер является асинхронным, поэтому возварщаемый тип Task</returns>
        static async Task Main()
        {
            MyEcs ecs = new MyEcs();
            MyGui gui = new MyGui();

            gui.Run();

            var timer = new PeriodicTimer(TimeSpan.FromMilliseconds(100));

            while (await timer.WaitForNextTickAsync())
            {
                ecs.Update();
            }
        }
    }
}