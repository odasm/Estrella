﻿namespace Estrella.FiestaLib.Data
{
    public sealed class DropInfo
    {
        public DropGroupInfo Group { get; private set; }
        public float Rate { get; private set; }

        public DropInfo(DropGroupInfo group, float rate)
        {
            Group = group;
            Rate = rate;
        }
    }
}
