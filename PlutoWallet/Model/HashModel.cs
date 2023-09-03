﻿using System;
using Substrate.NetApi;
using Substrate.NetApi.Model.Types.Primitive;

namespace PlutoWallet.Model
{
	public class HashModel
	{
		public static U32 GetU32FromBlake2_128Concat(string hash)
		{
			if (hash.Substring(0, 2) == "0x")
			{
				hash = hash.Substring(2);
			}

			if (hash.Length != 40)
			{
				throw new Exception("bad hash input");
			}

			U32 num = new U32();
			num.Create(Utils.HexToByteArray(hash.Substring(32, 8)));

			return num;
		}

        public static U64 GetU64FromBlake2_128Concat(string hash)
        {
            if (hash.Substring(0, 2) == "0x")
            {
                hash = hash.Substring(2);
            }

            if (hash.Length != 48)
            {
                throw new Exception("bad hash input");
            }

            U64 num = new U64();
            num.Create(Utils.HexToByteArray(hash.Substring(32, 16)));

            return num;
        }

        public static U128 GetU128FromBlake2_128Concat(string hash)
        {
            if (hash.Substring(0, 2) == "0x")
            {
                hash = hash.Substring(2);
            }

            if (hash.Length != 64)
            {
                throw new Exception("bad hash input");
            }

            U128 num = new U128();
            num.Create(Utils.HexToByteArray(hash.Substring(32, 32)));

            return num;
        }
    }
}

