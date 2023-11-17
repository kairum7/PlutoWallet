﻿using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Substrate.NetApi;
using PlutoWallet.Constants;
using Uniquery;

namespace PlutoWallet.Model
{
    public class RmrkAttributes
    {
        [JsonPropertyName("trait_type")]
        public string TraitType { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("display")]
        public string Display { get; set; }
    }

    public class RmrkMetadata
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("animation_url")]
        public string AnimationUrl { get; set; }

        [JsonPropertyName("attributes")]
        public List<RmrkAttributes> Attributes { get; set; }

        [JsonPropertyName("external_url")]
        public string ExternalUrl { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class UniqueryModel
	{
        private static Endpoint GetEndpointFromFormat(string nftFormat)
        {
            switch (nftFormat)
            {
                case "rmrk":
                    Endpoint rmrk = Endpoints.GetEndpointDictionary["kusama"];
                    rmrk.Name = "Rmrk";
                    return rmrk;
                case "rmrk2":
                    Endpoint rmrk2 = Endpoints.GetEndpointDictionary["kusama"];
                    rmrk2.Name = "Rmrk2";
                    return rmrk2;
                case "basilisk":
                    return Endpoints.GetEndpointDictionary["basilisk"];
                case "glmr":
                    return Endpoints.GetEndpointDictionary["moonbeam"];
                case "movr":
                    return Endpoints.GetEndpointDictionary["moonriver"];
                case "unique":
                    return Endpoints.GetEndpointDictionary["unique"];
                case "quartz":
                    return Endpoints.GetEndpointDictionary["quartz"];
                case "opal":
                    return Endpoints.GetEndpointDictionary["opal"];
                default:
                    return null;
            }
        }

        public static async Task<List<NFT>> GetAllNfts(CancellationToken token)
		{
			string address = Utils.GetAddressFrom(KeysModel.GetPublicKeyBytes(), 2);

			List<Nft> nfts = new List<Nft>();
            int limit = 100;
            int offset = 0;
            string orderBy = "updatedAt_DESC";
            bool forSale = false;
            int eventsLimit = 0;

            nfts.AddRange(await Rmrk.NftListByOwner(address, limit, offset, orderBy, forSale, eventsLimit, 10, token));

            nfts.AddRange(await RmrkV2.NftListByOwner(address, limit, offset, orderBy, forSale, eventsLimit, 10, token));

            nfts.AddRange(await Unique.NftListByOwner(address, limit, offset, token));

            nfts.AddRange(await Quartz.NftListByOwner(address, limit, offset, token));

            nfts.AddRange(await Opal.NftListByOwner(address, limit, offset, token));

            nfts.AddRange(await Basilisk.NftListByOwner(address, limit, offset, orderBy, forSale, eventsLimit, 10, token));

            try
            {
                nfts.AddRange(await Glmr.NftListByOwner(address, limit, offset, orderBy, forSale, eventsLimit, token));
            }
            catch
            {

            }
            try
            {
                nfts.AddRange(await Movr.NftListByOwner(address, limit, offset, orderBy, forSale, eventsLimit, token));
            }
            catch
            {

            }
            nfts.AddRange(await Acala.NftListByOwner(address, limit, offset, token));

            nfts.AddRange(await Astar.NftListByOwner(address, limit, offset, token));

            nfts.AddRange(await Shiden.NftListByOwner(address, limit, offset, token));

            List<NFT> result = new List<NFT>();
            foreach (var nft in nfts)
            {
                result.Add(new NFT
                {
                    Name = nft.Name,
                    Description = nft.Meta.Description,
                    Image = IpfsModel.ToIpfsLink(nft.Meta.Image),
                    Endpoint = GetEndpointFromFormat(nft.NetworkFormat),
                });
            }

			return result;
        }
	}
}

