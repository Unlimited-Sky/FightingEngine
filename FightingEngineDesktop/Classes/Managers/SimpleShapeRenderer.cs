
using FightingEngine.Collision;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine
{
    public class SimpleShapeRenderer
    {
        private SpriteBatch _spriteBatch;
        private Texture2D _texture; //a 1x1 texture

        readonly Color _hitBoxColor = new Color(255, 0, 0);
        readonly Color _hurtBoxColor = new Color(0, 255, 0);
        readonly Color _characterColliderColor = new Color(0, 0, 255);
        readonly float _alphaFill = 0.25f;
        readonly float _alphaOutline = 0.75f;

        public SimpleShapeRenderer(SpriteBatch spriteBatch, GraphicsDevice graphicsDevice)
        {
            _spriteBatch = spriteBatch;
            _texture = new Texture2D(graphicsDevice, 1, 1, false, SurfaceFormat.Color);
            _texture.SetData(new[] { Color.White });
        }

        public void DrawLine(Point start, Point end, Color color, int width = 1)
        {
            DrawLine(start.X, start.Y, end.X, end.Y, color, width);
        }

        public void DrawLine(int x1, int y1, int x2, int y2, Color color, int width = 1)
        {
            drawLineRaw(x1, y1, x2, y2, color, width);
        }

        public void DrawRect(SimpleRect rect, Color color, bool filled = true, int width = 1)
        {
            DrawRect(rect.TopLeft, rect.BottomRight, color, filled, width);
        }

        public void DrawRect(Point topLeft, Point bottomRight, Color color, bool filled = true, int width = 1)
        {
            DrawRect(topLeft.Y, topLeft.X, bottomRight.Y, bottomRight.X, color, filled, width);
        }

        public void DrawCollisions(HitBoxRootNode hitBoxRootNode, Point origin)
        {
            foreach(SimpleRect rect in hitBoxRootNode.Children)
                drawCollisionBox(rect.WithOffset(origin), _hitBoxColor);
        }

        public void DrawCollisions(HurtBoxRootNode hurtBoxRootNode, Point origin)
        {
            foreach (SimpleRect rect in hurtBoxRootNode.Children)
                drawCollisionBox(rect.WithOffset(origin), _hurtBoxColor);
        }

        public void DrawCollision(CharacterCollider collider)
        {
            drawCollisionBox(collider, _characterColliderColor);
        }

        private void drawCollisionBox(SimpleRect rect, Color color)
        {
            DrawRect(rect, color * _alphaFill, true);
            DrawRect(rect, color * _alphaOutline, false);
        }

        public void DrawRect(int top, int left, int bottom, int right, Color color, bool filled = true, int width = 1)
        {
            if (filled)
            {
                drawFilledRect(top, left, bottom, right, color);
            }
            else
            {
                drawLineRaw(left, top, right, top, color, width);
                drawLineRaw(right, top, right, bottom, color, width);
                drawLineRaw(right, bottom, left, bottom, color, width);
                drawLineRaw(left, bottom, left, top, color, width);
            }
         }

        private void drawLineRaw(int x1, int y1, int x2, int y2, Color color, int width)
        {
            float distance = Vector2.Distance(new Vector2(x1, y1), new Vector2(x2, y2));
            float angle = (float)Math.Atan2(y2 - y1, x2 - x1);

            _spriteBatch.Draw(_texture, new Vector2(x1, y1), null, color, angle, Vector2.Zero,
                new Vector2(distance, width), SpriteEffects.None, 0);
        }

        private void drawFilledRect(int top, int left, int bottom, int right, Color color)
        {

            _spriteBatch.Draw(_texture, new Rectangle(left, top, right - left, bottom - top), color);
        }
    }
}
