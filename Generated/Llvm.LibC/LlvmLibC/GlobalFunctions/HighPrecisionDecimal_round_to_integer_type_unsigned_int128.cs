using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_round_to_integer_type_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal21round_to_integer_typeIoEET_NS0_14RoundDirectionE")]
	[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::HighPrecisionDecimal::round_to_integer_type<unsigned __int128>(__llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("unsigned __int128")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] Llvm_libc_20_1_2_internal_HighPrecisionDecimal* This, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Int128 x = default(Int128);
		int i = 0;
		Llvm_lifetime_start_p0.Invoke(16L, &x);
		x = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &i);
		unchecked
		{
			for (i = 0; i < This->Decimal_point && (uint)i < (uint)This->Num_digits; i++)
			{
				x = NumericHelper.Add(NumericHelper.Multiply(x, 10L), (Int128)(UInt128)(byte)((sbyte*)(&This->Digits))[(uint)i]);
			}
			for (; i < This->Decimal_point; i++)
			{
				x = NumericHelper.Multiply(x, 10L);
			}
			Int128 @int = NumericHelper.Add(x, (Int128)(UInt128)(HighPrecisionDecimal_should_round_up.Invoke(This, This->Decimal_point, Round) ? 1u : 0u));
			Llvm_lifetime_end_p0.Invoke(4L, &i);
			Llvm_lifetime_end_p0.Invoke(16L, &x);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
