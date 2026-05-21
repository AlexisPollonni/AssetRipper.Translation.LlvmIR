using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_is_disjoint
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11is_disjointEPKvS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::is_disjoint(void const*, void const*, unsigned long)")]
	public unsafe static bool Invoke([MangledName("p1")][NativeType("void const*")] void* P1, [MangledName("p2")][NativeType("void const*")] void* P2, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked((long)P1 - (long)P2);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = Cpp_bit_cast_unsigned_long_long.Invoke(&num);
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		Llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = -num;
		long num5 = Cpp_bit_cast_unsigned_long_long.Invoke(&num4);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		num3 = num5;
		bool result = unchecked((num < 0L) ? ((ulong)Size <= (ulong)num3) : ((ulong)Size <= (ulong)num2));
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
