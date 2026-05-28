using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class U128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_li5_u128EPKc")]
	[DemangledName("__llvm_libc_20_1_2_::operator\"\" _u128(char const*)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("x")][NativeType("char const*")] void* X)
	{
		Int128 @int = default(Int128);
		Struct_fiz2nb struct_fiz2nb = Internal_parse_with_prefix_unsigned_int128.Invoke(X);
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
