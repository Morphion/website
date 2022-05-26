/* hardhat.config.js */
require("@nomiclabs/hardhat-waffle")
const fs = require('fs')
const mnemonic = fs.readFileSync(".secret").toString().trim() || "01234567890123456789"
const apiKey = fs.readFileSync(".apiKey").toString().trim()

module.exports = {
  defaultNetwork: "hardhat",
  networks: {
    hardhat: {
      chainId: 1337
    },
    mumbai: {
      url: "https://rpc-mumbai.maticvigil.com",
      accounts: {mnemonic: mnemonic}
    }
//  unused configuration commented out for now
//  mumbai: {
//    url: "https://rpc-mumbai.maticvigil.com",
//    accounts: [process.env.privateKey]
//  }
  },
  solidity: {
    version: "0.8.4",
    settings: {
      optimizer: {
        enabled: true,
        runs: 200
      }
    }
  }
}