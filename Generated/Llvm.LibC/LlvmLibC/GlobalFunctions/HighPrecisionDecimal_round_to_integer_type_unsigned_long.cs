using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_round_to_integer_type_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal21round_to_integer_typeImEET_NS0_14RoundDirectionE")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::HighPrecisionDecimal::round_to_integer_type<unsigned long>(__llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		long num = 0L;
		int i = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &i);
		unchecked
		{
			for (i = 0; i < This->Decimal_point && (uint)i < (uint)This->Num_digits; i++)
			{
				num = num * 10L + (byte)((sbyte*)(&This->Digits))[(uint)i];
			}
			for (; i < This->Decimal_point; i++)
			{
				num *= 10L;
			}
			long result = num + (HighPrecisionDecimal_should_round_up.Invoke(This, This->Decimal_point, Round) ? 1L : 0L);
			Llvm_lifetime_end_p0.Invoke(4L, &i);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
