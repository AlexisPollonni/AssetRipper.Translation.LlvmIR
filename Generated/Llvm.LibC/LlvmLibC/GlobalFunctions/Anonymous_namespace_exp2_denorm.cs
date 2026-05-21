using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_exp2_denorm
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_111exp2_denormEd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::exp2_denorm(double)")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		double result = 0.0;
		int num = 0;
		double num2 = 0.0;
		double x = 0.0;
		int num3 = 0;
		int num4 = 0;
		int hi = 0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double num5 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double lo = 0.0;
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq2 = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = X + 3145728.0001220703;
		unchecked
		{
			int num6 = (int)(Cpp_bit_cast_unsigned_long_double.Invoke(&num2) >>> 19);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			num = num6;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (num >> 6) & 0x3F;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num & 0x3F;
			Llvm_lifetime_start_p0.Invoke(4L, &hi);
			hi = num >> 12;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			long num7 = (uint)num3;
			llvm_libc_20_1_2_NumberPair.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num7].Mid;
			long num8 = (uint)num3;
			llvm_libc_20_1_2_NumberPair.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num8].Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			long num9 = (uint)num4;
			llvm_libc_20_1_2_NumberPair2.Lo = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num9].Mid;
			long num10 = (uint)num4;
			llvm_libc_20_1_2_NumberPair2.Hi = ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID2.Pointer)[num10].Hi;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2);
			Llvm_libc_20_1_2_NumberPair* num11 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num11 = struct_4ydhja2.field_0;
			byte* num12 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num12 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = Fputil_multiply_add_double.Invoke(x, -0.000244140625, X);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = num5 * llvm_libc_20_1_2_NumberPair3.Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = Anonymous_namespace_poly_approx_d_jq287d.Invoke(num5);
			Llvm_lifetime_start_p0.Invoke(8L, &lo);
			lo = Fputil_multiply_add_double.Invoke(x2, y, llvm_libc_20_1_2_NumberPair3.Lo);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_vhbvq);
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
			Struct_8myw6y struct_8myw6y = Llvm_libc_20_1_2_ziv_test_denorm.Invoke(hi, llvm_libc_20_1_2_NumberPair3.Hi, lo, 1.6263032587282567E-19);
			Llvm_libc_20_1_2_cpp_optional_double_OptionalStorage* ptr3 = &llvm_libc_20_1_2_cpp_optional_vhbvq.Storage;
			Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
			((Struct_8myw6y*)ptr3)->field_0 = struct_8myw6y2.field_0;
			Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
			((Struct_8myw6y*)ptr3)->field_1 = struct_8myw6y3.field_1;
			int num13;
			if (Details_expects_bool_condition_bool.Invoke(Optional_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq), Expected: true))
			{
				result = *(double*)Optional_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq);
				num13 = 1;
			}
			else
			{
				num13 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq);
			switch (num13)
			{
			case 0:
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
				*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
				((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
				Struct_4ydhja struct_4ydhja4 = Anonymous_namespace_exp2_double_double.Invoke(num5, &llvm_libc_20_1_2_NumberPair3);
				Llvm_libc_20_1_2_NumberPair* num14 = &llvm_libc_20_1_2_NumberPair4;
				Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
				*(double*)num14 = struct_4ydhja5.field_0;
				byte* num15 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
				Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
				*(double*)num15 = struct_4ydhja6.field_1;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq2);
				sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_vhbvq2);
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
				Struct_8myw6y struct_8myw6y4 = Llvm_libc_20_1_2_ziv_test_denorm.Invoke(hi, llvm_libc_20_1_2_NumberPair4.Hi, llvm_libc_20_1_2_NumberPair4.Lo, 7.888609052210118E-31);
				Llvm_libc_20_1_2_cpp_optional_double_OptionalStorage* ptr6 = &llvm_libc_20_1_2_cpp_optional_vhbvq2.Storage;
				Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_0 = struct_8myw6y5.field_0;
				Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
				((Struct_8myw6y*)ptr6)->field_1 = struct_8myw6y6.field_1;
				if (Details_expects_bool_condition_bool.Invoke(Optional_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq2), Expected: true))
				{
					result = *(double*)Optional_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq2);
					num13 = 1;
				}
				else
				{
					num13 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq2);
				switch (num13)
				{
				case 0:
				{
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
					sbyte* ptr7 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
					*ptr7 = -86;
					ptr7[1] = -86;
					ptr7[2] = -86;
					((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
					sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
					*(long*)ptr8 = -6148914691236517206L;
					((long*)ptr8)[1] = -6148914691236517206L;
					Anonymous_namespace_exp2_f128.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, num5, hi, num3, num4);
					result = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
					break;
				}
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
				break;
			}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &lo);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(4L, &hi);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
