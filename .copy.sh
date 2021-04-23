#!/usr/local/bin/fish

find ./Assets/MonopolyProto/ -name "*.cs" -type f -delete
ditto ../prisel/protos/gen_csharp/Prisel ./Assets/MonopolyProto/Runtime/Prisel
ditto ../prisel/protos/gen_csharp/Monopoly/ ./Assets/MonopolyProto/Runtime/Monopoly