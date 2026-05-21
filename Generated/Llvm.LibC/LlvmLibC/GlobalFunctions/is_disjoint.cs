using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class is_disjoint
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11is_disjointEPKvS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::is_disjoint(void const*, void const*, unsigned long)")]
	public unsafe static bool Invoke([NativeType("void const*")] void* p1, [NativeType("void const*")] void* p2, [NativeType("unsigned long")] long size)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = unchecked((long)p1 - (long)p2);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = cpp_bit_cast_unsigned_long_long.Invoke(&num);
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = -num;
		long num5 = cpp_bit_cast_unsigned_long_long.Invoke(&num4);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		num3 = num5;
		bool result = unchecked((num < 0L) ? ((ulong)size <= (ulong)num3) : ((ulong)size <= (ulong)num2));
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
