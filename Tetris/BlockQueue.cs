using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class BlockQueue
    {
        readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new OBlock(),
            new JBlock(),
            new LBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };
        readonly Random rnd = new Random();
        public Block NextBlock { get; private set; }
        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }
        Block RandomBlock()
        {
            return blocks[rnd.Next(blocks.Length)];
        }
        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            } while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
