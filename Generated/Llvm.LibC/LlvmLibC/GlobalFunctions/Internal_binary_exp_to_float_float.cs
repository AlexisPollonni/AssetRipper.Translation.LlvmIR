using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_binary_exp_to_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19binary_exp_to_floatIfEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float> __llvm_libc_20_1_2_::internal::binary_exp_to_float<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, bool, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>")]
	public unsafe static Struct_3driym Invoke([MangledName("init_num.coerce")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>")] long Init_num, [MangledName("truncated")][NativeType("bool")] bool Truncated, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er = default(Internal_FloatConvertReturn_a8f9er);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up = default(Internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(Internal_ExpandedFloat_i7t5up);
		int num6 = 0;
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(Internal_ExpandedFloat_i7t5up);
		int num7 = 0;
		int num8 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up4 = default(Internal_ExpandedFloat_i7t5up);
		Struct_3driym result = default(Struct_3driym);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up) = Init_num;
			sbyte b4 = (Truncated ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = internal_ExpandedFloat_i7t5up.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_i7t5up.Exponent;
			sbyte* ptr = (sbyte*)(&internal_FloatConvertReturn_a8f9er);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)(&internal_FloatConvertReturn_a8f9er))[2] = -1431655766;
			FloatConvertReturn_float_Constructor.Invoke(&internal_FloatConvertReturn_a8f9er);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 255;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = Cpp_countl_zero_unsigned_int.Invoke(num);
			num <<= num4;
			num2 -= num4;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = checked(num2 + 32 + 127 - 1);
			if (num5 >= 255)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up2);
				internal_ExpandedFloat_i7t5up2.Mantissa = 0;
				internal_ExpandedFloat_i7t5up2.Exponent = 255;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er.Num, &internal_ExpandedFloat_i7t5up2, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up2);
				internal_FloatConvertReturn_a8f9er.Error = 34;
				goto IL_0437;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = 8;
			if (num5 <= 0)
			{
				num6 += checked(1 - num5);
				num5 = 0;
				if ((uint)num6 > 32u)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
					internal_ExpandedFloat_i7t5up3.Mantissa = 0;
					internal_ExpandedFloat_i7t5up3.Exponent = 0;
					Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er.Num, &internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
					internal_FloatConvertReturn_a8f9er.Error = 34;
					goto IL_0425;
				}
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 1 << num6 - 1;
			Llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = num7 - 1;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((num & num7) != 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (((num & num8) != 0 || (b4 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			if ((uint)num6 < 32u)
			{
				num >>>= num6;
				num &= 0x7FFFFF;
			}
			else
			{
				num = 0;
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((num & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
			switch (Round)
			{
			case RoundDirection_b3pcwy.Nearest:
				if ((b & 1) == 1 && ((b3 & 1) == 1 || (b2 & 1) == 1))
				{
					num++;
				}
				break;
			case RoundDirection_b3pcwy.Up:
				if ((b & 1) == 1 || (b2 & 1) == 1)
				{
					num++;
				}
				break;
			default:
				if ((b & 1) == 1 && (b2 & 1) == 1)
				{
					num++;
				}
				break;
			}
			if ((uint)num > 8388607u)
			{
				num5 = checked(num5 + 1);
				if (num5 == 255)
				{
					internal_FloatConvertReturn_a8f9er.Error = 34;
				}
			}
			if (num5 == 0)
			{
				internal_FloatConvertReturn_a8f9er.Error = 34;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
			internal_ExpandedFloat_i7t5up4.Mantissa = num & 0x7FFFFF;
			internal_ExpandedFloat_i7t5up4.Exponent = num5;
			Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er.Num, &internal_ExpandedFloat_i7t5up4, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
			Llvm_lifetime_end_p0.Invoke(1L, &b3);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			goto IL_0425;
		}
		IL_0425:
		Llvm_lifetime_end_p0.Invoke(4L, &num6);
		goto IL_0437;
		IL_0437:
		Llvm_lifetime_end_p0.Invoke(4L, &num5);
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &internal_FloatConvertReturn_a8f9er, 12L, isVolatile: false);
		return result;
	}
}
