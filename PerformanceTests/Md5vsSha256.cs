using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;

namespace PerformanceTests;

public class Md5vsSha256
{
    private SHA256 sha256 = SHA256.Create();
    private MD5 md5 = MD5.Create();
    private byte[] data;

    [Params(1000, 10000)]
    public int ByteArraySize;

    [GlobalSetup]
    public void Setup()
    {
        data = new byte[ByteArraySize];
        new Random().NextBytes(data);
    }

    [Benchmark]
    public byte[] Sha256() => sha256.ComputeHash(data);

    [Benchmark]
    public byte[] Md5() => md5.ComputeHash(data);
}
