# PlutoWallet
A sample wallet that implements PlutoConnector.

# PlutoConnector
Allows any dApp to communicate with the supported wallets without compromising privateKeys.

# Terminology
- dApp = any application that wants to use the crypto functulionalities. In order to use dApps, it needs to communicate with the crypto wallet somehow, or it needs to know your privateKey (very insecure).

# Work / milestones

### part 1 - Plutonication (Pluto connector)
0) [-] create 2 new projects inside this solution:
  - 1 a class library (later on will be a Nuget package)
  - 2 mock dApp (testing app) - a simple console app that will connect to the wallet
1) [x] find out how to connect the 2 apps via websocket (look into resources)
2) [x] create the 2 basic call operations/methods:
  - OnConnect - 1st thing called when connection is successful - wallet returns publicKey to the dApp
  - RequestSign - dApp sends a sing request with the transaction data to the wallet and the wallet returns the signed data
  - ??? maybe more
3) [x] make this a modular package -> release to Nuget
  - make this better compatible with Ajuna.NetApi???
4) [ ] generate QR ~ not important

50) [ ] (VERY IMPORTANT) create a very detailed (and begginer friendly) documentation with how to use it and add examples

101) [ ] polkadot js integration (ask Rosťa for more)

102) [ ] make a javascript version

#### Socket solution
##### Hierarchy of classes and methods
- Connection Manager:
  - Connect()
  - Listen()
  - SendData()
  - ReceiveData()
  - CloseConnection()
- Message Factory:
  - CreateRequestMessage()
  - CreateResponseMessage()
- Message Processor:
  - ParseMessage()
  - ProcessMessage()
- Error Handler:
  - HandleException()
  - LogError()
  - SendErrorInformation()
##### Usecases
1. pair devices (inlude send public key <string> from wallet to dApp)
2. send transaction <"header",byte, byte, byte[]> from dApp to wallet:
  - wallet y/n -> response (failed due sth/rejected/accepted <enum>)
  - dApp: display status of transaction (response)
3. close connection (from both sides):
 - on connection lost event
 - send to other client message about cancelation ?

### part 2 - PlutoWallet
1) [x] generate mnemonics and show it to the user
1) [ ] enter mnemonics
1) [ ] enter private key
1) [ ] show the user raw privateKey
2) [ ] save the privateKey securely (probably always ask for password)
3) [ ] (extra) secure with password/biometrics
4) [x] generate a publicKey from the privateKey
5) [x] (extra - EASY) make ss58 encoded publicKeys
6) [x] get the current balance
7) [ ] (extra) show the balance in USD (use coingecko free api)
8) [x] add a transfer functionality
9) [ ] add the ability to sign any transaction
10) [ ] implement the PlutoConnect link (a specialized link that will open PlutoWallet app and pass in all the info needed to allow the connection between the dApp and the wallet)
11) [ ] QR scanner
12) [ ] improve UI
13) [x] add multiple chain support
14) [ ] (extra) the ability to add other unknown chains manually
15) [ ] (extra) NFT implementation
16) [ ] show other funganble tokens
17) [ ] plutonication deep link

### Other milestones

#### #1 NFTs integration
- show all owned NFTs
- allow minting your own NFTs
- NFT dex implementation

#### #2 Staking
- show stake pools
- show gains
- more...

#### #3 dApp gallery
- dApp promotion page

#### #4 Voting

#### #5 ink!

#### #6 buy crypto
  
### (extra) part 3 - browser extension

- Not a priority right now.

# Resources to use

### Hackathon:
- https://www.polkadotglobalseries.com/

### Socket solutions:
- [ ] https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/sockets/socket-services?source=recommendations
- [ ] https://github.com/sta/websocket-sharp / http://sta.github.io/websocket-sharp/#secure-connection

### Polkadot solutions:
- https://github.com/ajuna-network
- Ajuna transaction example: https://github.com/ajuna-network/SubstrateNetApi/issues/21#issuecomment-940421149
- reading storage: https://www.shawntabrizi.com/substrate/querying-substrate-storage-via-rpc/

### Blockchain communication tools
- https://polkadot.js.org/apps/

### parity signer
- [ ] https://www.parity.io/technologies/signer/
- [ ] https://paritytech.github.io/parity-signer/about/Security-And-Privacy.html

### Inspiration:
- https://walletconnect.com/

### Sample transfer to be implemented:

```
public static Method Transfer(AjunaExample.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            return new Method(5, "Balances", 0, "transfer", byteArray.ToArray());
        }
```
