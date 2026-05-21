using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_binary_exp_to_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19binary_exp_to_floatIfEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float> __llvm_libc_20_1_2_::internal::binary_exp_to_float<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, bool, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>")]
	public unsafe static Struct_3driym Invoke([MangledName("init_num.coerce")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>")] long init_num, [NativeType("bool")] bool truncated, [NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy round)
	{
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er2 = default(internal_FloatConvertReturn_a8f9er);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		int num6 = 0;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up4 = default(internal_ExpandedFloat_i7t5up);
		int num7 = 0;
		int num8 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up5 = default(internal_ExpandedFloat_i7t5up);
		Struct_3driym result = default(Struct_3driym);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up2) = init_num;
			sbyte b4 = (truncated ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = internal_ExpandedFloat_i7t5up2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_i7t5up2.exponent;
			sbyte* ptr = (sbyte*)(&internal_FloatConvertReturn_a8f9er2);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)(&internal_FloatConvertReturn_a8f9er2))[2] = -1431655766;
			FloatConvertReturn_float_Constructor.Invoke(&internal_FloatConvertReturn_a8f9er2);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 255;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = cpp_countl_zero_unsigned_int.Invoke(num);
			num <<= num4;
			num2 -= num4;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = checked(num2 + 32 + 127 - 1);
			if (num5 >= 255)
			{
				llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				internal_ExpandedFloat_i7t5up3.mantissa = 0;
				internal_ExpandedFloat_i7t5up3.exponent = 255;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				internal_FloatConvertReturn_a8f9er2.error = 34;
				goto IL_0437;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = 8;
			if (num5 <= 0)
			{
				num6 += checked(1 - num5);
				num5 = 0;
				if ((uint)num6 > 32u)
				{
					llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
					internal_ExpandedFloat_i7t5up4.mantissa = 0;
					internal_ExpandedFloat_i7t5up4.exponent = 0;
					llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up4, 8L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
					internal_FloatConvertReturn_a8f9er2.error = 34;
					goto IL_0425;
				}
			}
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = 1 << num6 - 1;
			llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = num7 - 1;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((num & num7) != 0) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (sbyte)(byte)(((num & num8) == 0) ? (((b4 & 1) == 1) ? 1 : 0) : (-1));
			if ((uint)num6 < 32u)
			{
				num >>>= num6;
				num &= 0x7FFFFF;
			}
			else
			{
				num = 0;
			}
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((num & 1) != 0) ? ((sbyte)1) : ((sbyte)0));
			switch (round)
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
					internal_FloatConvertReturn_a8f9er2.error = 34;
				}
			}
			if (num5 == 0)
			{
				internal_FloatConvertReturn_a8f9er2.error = 34;
			}
			llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up5);
			internal_ExpandedFloat_i7t5up5.mantissa = num & 0x7FFFFF;
			internal_ExpandedFloat_i7t5up5.exponent = num5;
			llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up5, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up5);
			llvm_lifetime_end_p0.Invoke(1L, &b3);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			goto IL_0425;
		}
		IL_0425:
		llvm_lifetime_end_p0.Invoke(4L, &num6);
		goto IL_0437;
		IL_0437:
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_memcpy_p0_p0_i64.Invoke(&result, &internal_FloatConvertReturn_a8f9er2, 12L, isVolatile: false);
		return result;
	}
}
