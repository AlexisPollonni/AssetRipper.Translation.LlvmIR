using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_abs_zj72qx
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE13IntegerWriter3absEl")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerWriter::abs(long)")]
	[CleanName("IntegerWriter_abs")]
	public unsafe static long Invoke([NativeType("long")] long value)
	{
		long num = 0L;
		num = value;
		if (num >= 0L)
		{
			return num;
		}
		if (num == integer_impl_long_9223372036854775808l_9223372036854775807l_min.Invoke())
		{
			return cpp_bit_cast_unsigned_long_long.Invoke(&num);
		}
		return -num;
	}
}
