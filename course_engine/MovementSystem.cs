using Leopotam.EcsLite;
using MyEngine.Ecs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngine
{
    public class MovementSystem : IEcsPreInitSystem, IEcsInitSystem, IEcsRunSystem, IEcsPostRunSystem, IEcsDestroySystem, IEcsPostDestroySystem
    {
        //EcsWorld world;
        //EcsFilter _filter;
        //EcsPool<Transform> _pool1, _pool2;
        public void PreInit(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Init() и до срабатывания IEcsInitSystem.Init() у всех систем.
        }

        public void Init(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Init() и после срабатывания IEcsPreInitSystem.PreInit() у всех систем.
            //_filter = world.Filter();

            //_pool1 = world.GetPool();

            //_pool2 = world.GetPool();

        }

        public void Run(IEcsSystems systems)
        {
            // Будет вызван один раз в момент работы IEcsSystems.Run().
            //foreach (e1 in _filter)
            //{

                // update e1.Transform

                // with e1.Move

            //}
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
    }
}
