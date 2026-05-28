using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_decimal_exp_to_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20decimal_exp_to_floatIfEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float> __llvm_libc_20_1_2_::internal::decimal_exp_to_float<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, bool, __llvm_libc_20_1_2_::internal::RoundDirection, char const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>")]
	public unsafe static Struct_3driym Invoke([MangledName("init_num.coerce")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>")] long Init_num, [MangledName("truncated")][NativeType("bool")] bool Truncated, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round, [MangledName("numStart")][NativeType("char const*")] void* NumStart, [MangledName("num_len")][NativeType("unsigned long")] long Num_len)
	{
		Internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er = default(Internal_FloatConvertReturn_a8f9er);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up = default(Internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		Internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er2 = default(Internal_FloatConvertReturn_a8f9er);
		Cpp_optional_6hseum cpp_optional_6hseum = default(Cpp_optional_6hseum);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(Internal_ExpandedFloat_i7t5up);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(Internal_ExpandedFloat_i7t5up);
		Cpp_optional_6hseum cpp_optional_6hseum2 = default(Cpp_optional_6hseum);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up4 = default(Internal_ExpandedFloat_i7t5up);
		Struct_8myw6y struct_8myw6y = default(Struct_8myw6y);
		Cpp_optional_6hseum cpp_optional_6hseum3 = default(Cpp_optional_6hseum);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up5 = default(Internal_ExpandedFloat_i7t5up);
		Struct_8myw6y struct_8myw6y2 = default(Struct_8myw6y);
		Cpp_optional_6hseum cpp_optional_6hseum4 = default(Cpp_optional_6hseum);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up6 = default(Internal_ExpandedFloat_i7t5up);
		Struct_8myw6y struct_8myw6y3 = default(Struct_8myw6y);
		Internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er3 = default(Internal_FloatConvertReturn_a8f9er);
		Struct_3driym struct_3driym = default(Struct_3driym);
		Struct_3driym result = default(Struct_3driym);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up) = Init_num;
			sbyte b = (Truncated ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = internal_ExpandedFloat_i7t5up.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_i7t5up.Exponent;
			Llvm_lifetime_start_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er2);
			sbyte* ptr = (sbyte*)(&internal_FloatConvertReturn_a8f9er2);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)(&internal_FloatConvertReturn_a8f9er2))[2] = -1431655766;
			FloatConvertReturn_float_Constructor.Invoke(&internal_FloatConvertReturn_a8f9er2);
			Llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum);
			sbyte* ptr2 = (sbyte*)(&cpp_optional_6hseum);
			sbyte* ptr3 = ptr2;
			*(int*)ptr3 = -1431655766;
			((int*)ptr3)[1] = -1431655766;
			ptr2[8] = -86;
			sbyte* ptr4 = ptr2 + 9;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			Optional_internal_ExpandedFloat_float_Constructor_fbx47x.Invoke(&cpp_optional_6hseum);
			if (num2 > Internal_get_upper_bound_float.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up2);
				internal_ExpandedFloat_i7t5up2.Mantissa = 0;
				internal_ExpandedFloat_i7t5up2.Exponent = 255;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.Num, &internal_ExpandedFloat_i7t5up2, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up2);
				internal_FloatConvertReturn_a8f9er2.Error = 34;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er, &internal_FloatConvertReturn_a8f9er2, 12L, isVolatile: false);
			}
			else if (num2 < Internal_get_lower_bound_float.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				internal_ExpandedFloat_i7t5up3.Mantissa = 0;
				internal_ExpandedFloat_i7t5up3.Exponent = 0;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.Num, &internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				internal_FloatConvertReturn_a8f9er2.Error = 34;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er, &internal_FloatConvertReturn_a8f9er2, 12L, isVolatile: false);
			}
			else
			{
				if ((b & 1) != 1)
				{
					Llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum2);
					Llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_i7t5up4, &internal_ExpandedFloat_i7t5up, 8L, isVolatile: false);
					Struct_8myw6y struct_8myw6y4 = Internal_clinger_fast_path_float.Invoke(*(long*)(&internal_ExpandedFloat_i7t5up4), Round);
					Cpp_optional_internal_ExpandedFloat_float_OptionalStorage* destination = &cpp_optional_6hseum2.Storage;
					struct_8myw6y = struct_8myw6y4;
					Llvm_memcpy_p0_p0_i64.Invoke(destination, &struct_8myw6y, 12L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_6hseum, &cpp_optional_6hseum2, 12L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum2);
					if (Optional_internal_ExpandedFloat_float_has_value.Invoke(&cpp_optional_6hseum))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er.Num, Optional_internal_ExpandedFloat_float_value.Invoke(&cpp_optional_6hseum), 8L, isVolatile: false);
						internal_FloatConvertReturn_a8f9er.Error = 0;
						goto IL_0564;
					}
				}
				Llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum3);
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_i7t5up5, &internal_ExpandedFloat_i7t5up, 8L, isVolatile: false);
				Struct_8myw6y struct_8myw6y5 = Internal_eisel_lemire_float.Invoke(*(long*)(&internal_ExpandedFloat_i7t5up5), Round);
				Cpp_optional_internal_ExpandedFloat_float_OptionalStorage* destination2 = &cpp_optional_6hseum3.Storage;
				struct_8myw6y2 = struct_8myw6y5;
				Llvm_memcpy_p0_p0_i64.Invoke(destination2, &struct_8myw6y2, 12L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_6hseum, &cpp_optional_6hseum3, 12L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum3);
				if (Optional_internal_ExpandedFloat_float_has_value.Invoke(&cpp_optional_6hseum))
				{
					if ((b & 1) != 1)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er.Num, Optional_internal_ExpandedFloat_float_value.Invoke(&cpp_optional_6hseum), 8L, isVolatile: false);
						internal_FloatConvertReturn_a8f9er.Error = 0;
						goto IL_0564;
					}
					Llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum4);
					sbyte* ptr5 = (sbyte*)(&cpp_optional_6hseum4);
					sbyte* ptr6 = ptr5;
					*(int*)ptr6 = -1431655766;
					((int*)ptr6)[1] = -1431655766;
					ptr5[8] = -86;
					sbyte* ptr7 = ptr5 + 9;
					*ptr7 = -86;
					ptr7[1] = -86;
					ptr7[2] = -86;
					internal_ExpandedFloat_i7t5up6.Mantissa = num + 1;
					internal_ExpandedFloat_i7t5up6.Exponent = num2;
					Struct_8myw6y struct_8myw6y6 = Internal_eisel_lemire_float.Invoke(*(long*)(&internal_ExpandedFloat_i7t5up6), Round);
					Cpp_optional_internal_ExpandedFloat_float_OptionalStorage* destination3 = &cpp_optional_6hseum4.Storage;
					struct_8myw6y3 = struct_8myw6y6;
					Llvm_memcpy_p0_p0_i64.Invoke(destination3, &struct_8myw6y3, 12L, isVolatile: false);
					int num3;
					if (Optional_internal_ExpandedFloat_float_has_value.Invoke(&cpp_optional_6hseum4) && Optional_internal_ExpandedFloat_float_PointerDereference.Invoke(&cpp_optional_6hseum)->Mantissa == Optional_internal_ExpandedFloat_float_PointerDereference.Invoke(&cpp_optional_6hseum4)->Mantissa && Optional_internal_ExpandedFloat_float_PointerDereference.Invoke(&cpp_optional_6hseum)->Exponent == Optional_internal_ExpandedFloat_float_PointerDereference.Invoke(&cpp_optional_6hseum4)->Exponent)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er.Num, Optional_internal_ExpandedFloat_float_value.Invoke(&cpp_optional_6hseum), 8L, isVolatile: false);
						internal_FloatConvertReturn_a8f9er.Error = 0;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum4);
					switch (num3)
					{
					case 0:
						break;
					default:
						goto IL_0564;
					}
				}
				Llvm_lifetime_start_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er3);
				struct_3driym = Internal_simple_decimal_conversion_float.Invoke(NumStart, Num_len, Round);
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er3, &struct_3driym, 12L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2, &internal_FloatConvertReturn_a8f9er3, 12L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er3);
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er, &internal_FloatConvertReturn_a8f9er2, 12L, isVolatile: false);
			}
			goto IL_0564;
		}
		IL_0564:
		Llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum);
		Llvm_lifetime_end_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er2);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &internal_FloatConvertReturn_a8f9er, 12L, isVolatile: false);
		return result;
	}
}
