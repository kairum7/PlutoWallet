﻿using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using PlutoWallet.Constants;
using PlutoWallet.Model;
using PlutoWallet.Components.Nft;

namespace PlutoWallet.ViewModel
{
	public partial class NftViewModel : ObservableObject
	{
        [ObservableProperty]
        private ObservableCollection<NFT> nfts = new ObservableCollection<NFT>() { };

        public NftViewModel()
		{

        }

        /**
        * Called in the BasePageViewModel
        */
        public async Task GetNFTsAsync(CancellationToken token)
        {
            var nftLoadingViewModel = DependencyService.Get<NftLoadingViewModel>();

            nftLoadingViewModel.IsVisible = true;

            foreach (Endpoint endpoint in Endpoints.GetAllEndpoints)
            {
                if (endpoint.SupportsNfts)
                {
                    UpdateNfts(await Model.NFTsModel.GetNFTsAsync(endpoint, token));
                }
            }

            UpdateNfts(await Model.UniqueryModel.GetAllNfts(token));

            UpdateNfts(await Model.AzeroId.AzeroIdNftsModel.GetNamesForAddress(Model.KeysModel.GetSubstrateKey(), token));

            nftLoadingViewModel.IsVisible = false;
        }

        public void UpdateNfts(List<NFT> newNfts)
        {
            foreach (NFT newNft in newNfts)
            {
                bool isContained = false;
                foreach (NFT savedNft in Nfts)
                {
                    if (savedNft.Equals(newNft))
                    {
                        isContained = true;
                    }
                }

                // if not contained, add the NFT to the layout and saved list
                if (!isContained)
                {
                    Nfts.Add(newNft);
                }
            }
        }

    }
}

