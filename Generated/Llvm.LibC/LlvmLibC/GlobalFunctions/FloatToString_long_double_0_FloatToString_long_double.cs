using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EEC2Ee")]
[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::FloatToString(long double)")]
internal static partial class FloatToString_long_double_0_FloatToString_long_double
{
	public unsafe static void Invoke(FloatToString_8m29tk* @this, double init_float)
	{
		Int128 mantissa = default(Int128);
		fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&@this->float_bits, init_float);
		@this->is_negative = 0;
		@this->exponent = 0;
		@this->mantissa = 0L;
		BigInt_16512ul_false_unsigned_long_BigInt_int_void_int.Invoke(&@this->float_as_fixed, 0);
		@this->int_block_index = 0;
		InlineArray549_Int32* block_buffer = &@this->block_buffer;
		unchecked
		{
			*(int*)block_buffer = 0;
			nint num = (nint)((byte*)block_buffer + 4);
			int* ptr = (int*)block_buffer + 549;
			while (true)
			{
				void* ptr2 = (void*)num;
				*(int*)ptr2 = 0;
				int* ptr3 = (int*)ptr2 + 1;
				if (ptr3 == ptr)
				{
					break;
				}
				num = (nint)ptr3;
			}
			@this->block_buffer_valid = 0L;
			bool num2 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&@this->float_bits);
			@this->is_negative = (num2 ? ((sbyte)1) : ((sbyte)0));
			@this->exponent = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent_const.Invoke(&@this->float_bits);
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&@this->float_bits);
			Int128* num3 = &mantissa;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb2.field_0;
			byte* num4 = (byte*)(&mantissa) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num4 = struct_fiz2nb3.field_1;
			@this->mantissa = mantissa;
		}
		@this->exponent -= 63;
		FloatToString_long_double_0_init_convert.Invoke(@this);
	}
}
