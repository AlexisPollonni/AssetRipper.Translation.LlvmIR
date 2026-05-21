using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FloatToString_long_double_0_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13FloatToStringIeLi0EEC2Ee")]
	[DemangledName("__llvm_libc_20_1_2_::FloatToString<long double, 0>::FloatToString(long double)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_FloatToString_8m29tk* This, [MangledName("init_float")][NativeType("long double")] double Init_float)
	{
		Int128 mantissa = default(Int128);
		FPBits_long_double_Constructor.Invoke(&This->Float_bits, Init_float);
		This->Is_negative = 0;
		This->Exponent = 0;
		This->Mantissa = 0L;
		BigInt_16512ul_false_unsigned_long_BigInt_int_void.Invoke(&This->Float_as_fixed, 0);
		This->Int_block_index = 0;
		InlineArray549_Int32* block_buffer = &This->Block_buffer;
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
			This->Block_buffer_valid = 0L;
			bool num2 = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg.Invoke(&This->Float_bits);
			This->Is_negative = (num2 ? ((sbyte)1) : ((sbyte)0));
			This->Exponent = FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_exponent.Invoke(&This->Float_bits);
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&This->Float_bits);
			Int128* num3 = &mantissa;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num3 = struct_fiz2nb2.field_0;
			byte* num4 = (byte*)(&mantissa) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num4 = struct_fiz2nb3.field_1;
			This->Mantissa = mantissa;
		}
		This->Exponent -= 63;
		FloatToString_long_double_0_init_convert.Invoke(This);
	}
}
