[![Build Status](https://travis-ci.org/leewalkergm/ssqlib.svg?branch=master)](https://travis-ci.org/leewalkergm/ssqlib) [![Package Status](https://img.shields.io/nuget/v/SSQLib.svg)](https://www.nuget.org/packages/SSQLib/)

[SSQLib](http://leewalkergm.github.io/ssqlib/)
==============================================

### *Source Server Query Library*

A Source Server Query Library - Exported from code.google.com/p/ssqlib

*I did not write this code originally - it lived on google code and was going to be lost when that system was closed so I copied it over*

Using SSQLib
------------

```
using SSQLib;
using System.Net;

public void GetServerInfo()
{
    string ip = "127.0.0.1";
    int port = 27015;

    IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse(ip), port);

    SSQL query = new SSQL();
    ServerInfo serverInformation = query.Server(endpoint);

    //You can now look at the properties of serverInformation to see what information you can retrieve.

    List<PlayerInfo> players = query.Players(endpoint)

    int playerCount = players.Count;
}
```
