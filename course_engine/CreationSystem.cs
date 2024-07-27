using Leopotam.EcsLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngine
{
    public class CreationSystem : IEcsPreInitSystem, IEcsInitSystem, IEcsRunSystem, IEcsPostRunSystem, IEcsDestroySystem, IEcsPostDestroySystem
    {
        //EcsWorld world;
        //EcsPool<Transform> e1;
        public void PreInit(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Init() и до срабатывания IEcsInitSystem.Init() у всех систем.
        }

        public void Init(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Init() и после срабатывания IEcsPreInitSystem.PreInit() у всех систем.

            //e1 = world.NewEntity();

            //Pool<Transform>.Add(e1);

            //Pool<Move>.Add(e1);

            //set e1.Transform

            //set e1.Move
        }

        public void Run(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Run().
        }

        public void PostRun(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Run() после срабатывания IEcsRunSystem.Run() у всех систем.
        }

        public void Destroy(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Destroy() и до срабатывания IEcsPostDestroySystem.PostDestroy() у всех систем.
        }

        public void PostDestroy(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Destroy() и после срабатывания IEcsDestroySystem.Destroy() у всех систем.
        }
        //public CreationSystem()
        //{
        //    Init() {

        //        e1 = world.NewEntity();

        //        Pool<Transform>.Add(e1);

        //        Pool<Move>.Add(e1);

        //        // set e1.Transform

        //        // set e1.Move

        //    }
        //}
    }
}
