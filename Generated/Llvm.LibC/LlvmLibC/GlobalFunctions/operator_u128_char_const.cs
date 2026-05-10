using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_li5_u128EPKc")]
[DemangledName("__llvm_libc_20_1_2_::operator\"\" _u128(char const*)")]
internal static partial class operator_u128_char_const
{
	public unsafe static Struct_fiz2nb Invoke(void* x)
	{
		Int128 @int = default(Int128);
		Struct_fiz2nb struct_fiz2nb = unsigned_int128_internal_parse_with_prefix_unsigned_int128_char_const.Invoke(x);
		Int128* num = &@int;
		Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
		unchecked
		{
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 int2 = @int;
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}
