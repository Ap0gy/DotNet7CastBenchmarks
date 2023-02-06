# C# .Net 7 Casting Benchmarks

## Basic Casts:
|    Method |     Mean |     Error |    StdDev | Allocated |
|---------- |---------:|----------:|----------:|----------:|
|  SafeCast | 1.996 ns | 0.0865 ns | 0.0809 ns |         - |
| MatchCast | 1.449 ns | 0.0360 ns | 0.0337 ns |         - |
|  HardCast | 1.039 ns | 0.0127 ns | 0.0119 ns |         - |

## Working with collections and LINQ:
|            Method |      Mean |     Error |    StdDev | Allocated |
|------------------ |----------:|----------:|----------:|----------:|
|           Cast_As | 18.749 us | 0.0685 us | 0.0641 us |  16.34 KB |
|           Cast_Is | 18.149 us | 0.1661 us | 0.1554 us |  16.34 KB |
|            OfType | 17.365 us | 0.1434 us | 0.1341 us |   16.3 KB |
|       HardCast_As |  8.073 us | 0.0731 us | 0.0684 us |  16.36 KB |
|       HardCast_Is |  7.967 us | 0.0365 us | 0.0341 us |  16.36 KB |
|   HardCast_TypeOf |  7.068 us | 0.0542 us | 0.0480 us |  16.36 KB |
| HardCast_UnsafeAs |  7.035 us | 0.0410 us | 0.0383 us |  16.36 KB |



<p>HardCasting collections is more than twice as fast on average for the collections. Similarly hard casting was the fastest of the standard casts, with the slowest being safe casts.</p>
<p>HardCast TypeOf is fastest safe-cast but  will fail with inheritance (shouldn't be a problem if you're correctly favouring composition), with OfType looking the cleanest.</p>
<p>Hard casting is the fastest and safecasting is the slowest of the standard casts.</p>

<p>Overall, <b>speed variation between different cast techniques are tiny</b>, so it's worth focussing on using the most clean/maintainabe cast type depending on the context.</p>
