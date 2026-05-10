using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp18bit_or_static_castIilEET_RKT0_")]
[DemangledName("int __llvm_libc_20_1_2_::cpp::bit_or_static_cast<int, long>(long const&)")]
internal static partial class int_cpp_bit_or_static_cast_int_long_long_const
{
	public unsafe static int Invoke(void* from)
	{
		return unchecked((int)(*(long*)from));
	}
}
