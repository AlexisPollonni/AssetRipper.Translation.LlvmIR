using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_112exp10_denormEd")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp10_denorm(double)")]
internal static partial class anonymous_namespace_exp10_denorm_double
{
	public unsafe static double Invoke(double x)
	{
		double result = 0.0;
		double num = 0.0;
		int num2 = 0;
		double num3 = 0.0;
		int num4 = 0;
		int num5 = 0;
		int hi = 0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		NumberPair numberPair3 = default(NumberPair);
		double z = 0.0;
		double num6 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double lo = 0.0;
		cpp_optional_s4iqgj cpp_optional_s4iqgj2 = default(cpp_optional_s4iqgj);
		NumberPair numberPair4 = default(NumberPair);
		cpp_optional_s4iqgj cpp_optional_s4iqgj3 = default(cpp_optional_s4iqgj);
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = fputil_multiply_add_double_double_double.Invoke(x, 3.321928094887362, 3145728.0001220703);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = (int)(cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num) >>> 19);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = num2;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = (num2 >> 6) & 0x3F;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num2 & 0x3F;
			llvm_lifetime_start_p0.Invoke(4L, &hi);
			hi = num2 >> 12;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			long num7 = (uint)num4;
			numberPair.lo = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num7].mid;
			long num8 = (uint)num4;
			numberPair.hi = ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num8].hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			*(double*)(&numberPair2) = double.NaN;
			((double*)(&numberPair2))[1] = double.NaN;
			long num9 = (uint)num5;
			numberPair2.lo = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num9].mid;
			long num10 = (uint)num5;
			numberPair2.hi = ((fputil_TripleDouble*)EXP2_MID2.Pointer)[num10].hi;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_quick_mult_27ul_NumberPair_double_const_NumberPair_double_const.Invoke(&numberPair, &numberPair2);
			NumberPair* num11 = &numberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num11 = struct_4ydhja2.field_0;
			byte* num12 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num12 = struct_4ydhja3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double_double_double.Invoke(num3, -7.349365128561658E-05, x);
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = fputil_multiply_add_double_double_double.Invoke(num3, 4.649201285928778E-16, z);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = num6 * numberPair3.hi;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = anonymous_namespace_poly_approx_d_double_45.Invoke(num6);
			llvm_lifetime_start_p0.Invoke(8L, &lo);
			lo = fputil_multiply_add_double_double_double.Invoke(x2, y, numberPair3.lo);
			llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_s4iqgj2);
			sbyte* ptr = (sbyte*)(&cpp_optional_s4iqgj2);
			*(double*)ptr = double.NaN;
			ptr[8] = -86;
			sbyte* ptr2 = ptr + 9;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			Struct_8myw6y struct_8myw6y = ziv_test_denorm_int_double_double_double.Invoke(hi, numberPair3.hi, lo, 1.6263032587282567E-19);
			cpp_optional_double_OptionalStorage* ptr3 = &cpp_optional_s4iqgj2.storage;
			Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
			((Struct_8myw6y*)ptr3)->field_0 = struct_8myw6y2.field_0;
			Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
			((Struct_8myw6y*)ptr3)->field_1 = struct_8myw6y3.field_1;
			int num13;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_double_has_value_const.Invoke(&cpp_optional_s4iqgj2), expected: true))
			{
				result = *(double*)cpp_optional_double_value.Invoke(&cpp_optional_s4iqgj2);
				num13 = 1;
			}
			else
			{
				num13 = 0;
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_s4iqgj2);
			switch (num13)
			{
			case 0:
			{
				llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
				*(double*)(&numberPair4) = double.NaN;
				((double*)(&numberPair4))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja4 = anonymous_namespace_exp10_double_double_double_double_NumberPair_double_const.Invoke(x, num3, &numberPair3);
				NumberPair* num14 = &numberPair4;
				Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
				*(double*)num14 = struct_4ydhja5.field_0;
				byte* num15 = (byte*)(&numberPair4) + 8u;
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
				*(double*)num15 = struct_4ydhja6.field_1;
				llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_s4iqgj3);
				sbyte* ptr4 = (sbyte*)(&cpp_optional_s4iqgj3);
				*(double*)ptr4 = double.NaN;
				ptr4[8] = -86;
				sbyte* ptr5 = ptr4 + 9;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				ptr5[3] = -86;
				ptr5[4] = -86;
				ptr5[5] = -86;
				ptr5[6] = -86;
				Struct_8myw6y struct_8myw6y4 = ziv_test_denorm_int_double_double_double.Invoke(hi, numberPair4.hi, numberPair4.lo, 2.3665827156630354E-30);
				cpp_optional_double_OptionalStorage* ptr6 = &cpp_optional_s4iqgj3.storage;
				Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_0 = struct_8myw6y5.field_0;
				Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_1 = struct_8myw6y6.field_1;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(cpp_optional_double_has_value_const.Invoke(&cpp_optional_s4iqgj3), expected: true))
				{
					result = *(double*)cpp_optional_double_value.Invoke(&cpp_optional_s4iqgj3);
					num13 = 1;
				}
				else
				{
					num13 = 0;
				}
				llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_s4iqgj3);
				switch (num13)
				{
				case 0:
				{
					llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					*(sbyte*)(&fputil_DyadicFloat_kt2kd5) = -86;
					sbyte* ptr7 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 1;
					*ptr7 = -86;
					ptr7[1] = -86;
					ptr7[2] = -86;
					((int*)(&fputil_DyadicFloat_kt2kd5))[1] = -1431655766;
					sbyte* ptr8 = (sbyte*)(&fputil_DyadicFloat_kt2kd5) + 8;
					*(long*)ptr8 = -6148914691236517206L;
					((long*)ptr8)[1] = -6148914691236517206L;
					anonymous_namespace_exp10_f128_double_double_int_int.Invoke(&fputil_DyadicFloat_kt2kd5, x, num3, num4, num5);
					result = fputil_DyadicFloat_128ul_operator_double_double_void_const.Invoke(&fputil_DyadicFloat_kt2kd5);
					llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
					break;
				}
				}
				llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
				break;
			}
			}
			llvm_lifetime_end_p0.Invoke(8L, &lo);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(4L, &hi);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
