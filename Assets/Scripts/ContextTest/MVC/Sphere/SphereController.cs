﻿using UnityEngine;


namespace BeastHunter
{
    public sealed class SphereController : IAwake, IUpdate
    {
        #region Fields

        private readonly GameContext _context;

        #endregion


        #region ClassLifeCycle

        public SphereController(GameContext context, Services services)
        {
            _context = context;
        }

        #endregion


        #region Updating

        public void Updating()
        {
            _context._sphereModel.Move();
            _context._sphereModel.ChangeBox();
        }

        #endregion


        #region OnAwake


        public void OnAwake()
        {
            var SphereData = Data.SphereData;
            GameObject instance = GameObject.Instantiate(SphereData.Prefab);
            SphereModel Sphere = new SphereModel(instance, SphereData);
            _context._sphereModel = Sphere;
        }

        #endregion        
    }
}


