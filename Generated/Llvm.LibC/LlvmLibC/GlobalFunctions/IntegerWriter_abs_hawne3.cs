using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_abs_hawne3
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter3absEi")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::abs(int)")]
	[CleanName("IntegerWriter_abs")]
	public unsafe static int Invoke([NativeType("int")] int value)
	{
		int num = 0;
		num = value;
		if (num >= 0)
		{
			return num;
		}
		if (num == integer_impl_int_2147483648_2147483647_min.Invoke())
		{
			return cpp_bit_cast_unsigned_int_int.Invoke(&num);
		}
		return -num;
	}
}
