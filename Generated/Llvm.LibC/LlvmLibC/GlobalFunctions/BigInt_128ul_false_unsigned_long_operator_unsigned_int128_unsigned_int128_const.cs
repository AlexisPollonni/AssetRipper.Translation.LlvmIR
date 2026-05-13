using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEcvT_IoEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator unsigned __int128<unsigned __int128>() const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_unsigned_int128_unsigned_int128_const
{
	public unsafe static Struct_fiz2nb Invoke(anon_izyfb7* @this)
	{
		Int128 @int = default(Int128);
		Struct_fiz2nb struct_fiz2nb = cpp_enable_if_cpp_is_integral_v_unsigned_int128_cpp_is_same_v_unsigned_int128_bool_unsigned_int128_type_BigInt_128ul_false_unsigned_long_to_unsigned_int128_const.Invoke(@this);
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
