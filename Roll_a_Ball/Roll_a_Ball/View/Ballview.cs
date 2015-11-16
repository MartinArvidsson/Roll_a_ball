﻿using Roll_a_Ball.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Roll_a_Ball.View
{

    class Ballview
    {
        //BallSimulation ballsimulation = new BallSimulation();
        //Camera camera = new Camera();

        Texture2D box;
        Texture2D ball;
        private Camera camera;
        private BallSimulation ballSimulation;


        public Ballview(GraphicsDeviceManager graphics, BallSimulation ballsimulation, ContentManager Content)
        {
            ball = Content.Load<Texture2D>("BALL.png");
            
            box = new Texture2D(graphics.GraphicsDevice,1,1);
            box.SetData<Color>(new Color[]
                {
                    Color.White
                });
                camera = new Camera(graphics.GraphicsDevice.Viewport);

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();
            spritebatch.Draw(box,camera.getGame(),Color.Black);
            spritebatch.End();

        }
    }
}
