using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leopotam.EcsLite;
using System;
using System.Diagnostics.Tracing;
using Leopotam.EcsLite;

namespace MyEngine
{
    
    namespace Ecs
    {
        /// <summary>
        /// класс MyEcs
        /// </summary>
        public class MyEcs
        {

            EcsWorld _world;
            /// <summary>
            /// пустой конструктор
            /// </summary>
            public MyEcs()
            {
                //Init()
                //{
                //    // Будет вызван один раз в момент работы IEcsSystems.Init() и после срабатывания IEcsPreInitSystem.PreInit() у всех систем.

                //    e1 = world.NewEntity();

                //    Pool<Transform>.Add(e1);

                //    Pool<Move>.Add(e1);

                //    // set e1.Transform

                //    // set e1.Move
                //}

            }
            /// <summary>
            /// метод обновления данных
            /// </summary>
            public async void Update()
            {

            }

            public int[] Entities
            {
                get
                {
                    int[] entities = new int[_world.GetEntitiesCount()];
                    _world.GetAllEntities(ref entities);
                    return entities;
                }
            }
            public IEcsPool[] Pools
            {
                get
                {
                    IEcsPool[] pools = new IEcsPool[_world.GetPoolsCount()];
                    _world.GetAllPools(ref pools);
                    return pools;
                }
            }

            public void UpdateEntity(int Entity, IECSComponent component)
            {
                IEcsPool pool = _world.GetExitstingRawPool(component.GetType());
                if (pool.Has(Entity))
                {
                    IECSComponent ecsComponent = pool.GetRaw(Entity) as IECSComponent;
                    pool.SetRaw(Entity, component);
                }
                else
                {
                    pool.AddRaw(Entity, component);
                }
            }
        }
    }
}
