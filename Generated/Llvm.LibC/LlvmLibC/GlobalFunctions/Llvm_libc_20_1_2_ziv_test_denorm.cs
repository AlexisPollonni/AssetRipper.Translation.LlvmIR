using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_ziv_test_denorm
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15ziv_test_denormEiddd")]
	[DemangledName("__llvm_libc_20_1_2_::ziv_test_denorm(int, double, double, double)")]
	public unsafe static Struct_8myw6y Invoke([MangledName("hi")][NativeType("int")] int Hi, [MangledName("mid")][NativeType("double")] double Mid, [MangledName("lo")][NativeType("double")] double Lo, [MangledName("err")][NativeType("double")] double Err)
	{
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		double x = 0.0;
		double num = 0.0;
		long num2 = 0L;
		double num3 = 0.0;
		long num4 = 0L;
		double num5 = 0.0;
		long num6 = 0L;
		double num7 = 0.0;
		long num8 = 0L;
		double num9 = 0.0;
		long num10 = 0L;
		double num11 = 0.0;
		double num12 = 0.0;
		double num13 = 0.0;
		double num14 = 0.0;
		double num15 = 0.0;
		long num16 = 0L;
		double num17 = Mid;
		x = Lo;
		num = Err;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = (long)checked(Hi + 1022) << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
		}
		num4 = num2 + Cpp_bit_cast_long_double.Invoke(&num17);
		double num18 = Cpp_bit_cast_double_long.Invoke(&num4);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		num3 = num18;
		Llvm_lifetime_start_p0.Invoke(8L, &num5);
		bool num19 = NumericHelper.IsUnorderedOrNotEquals(x, 0.0);
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		double num20;
		if (num19)
		{
			num6 = num2 + Cpp_bit_cast_long_double.Invoke(&x);
			num20 = Cpp_bit_cast_double_long.Invoke(&num6);
		}
		else
		{
			num20 = 0.0;
		}
		Llvm_lifetime_end_p0.Invoke(8L, &num6);
		num5 = num20;
		Llvm_lifetime_start_p0.Invoke(8L, &num7);
		num7 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num8);
		num8 = 4602678819172646912L;
		if (1.0 - num3 > num5)
		{
			num += 2.220446049250313E-16;
			num7 = 1.0;
			num8 = 4607182418800017408L;
		}
		Llvm_lifetime_start_p0.Invoke(8L, &num9);
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = num2 + Cpp_bit_cast_long_double.Invoke(&num);
		double num21 = Cpp_bit_cast_double_long.Invoke(&num10);
		Llvm_lifetime_end_p0.Invoke(8L, &num10);
		num9 = num21;
		Llvm_lifetime_start_p0.Invoke(8L, &num11);
		num11 = num5 + num9;
		Llvm_lifetime_start_p0.Invoke(8L, &num12);
		num12 = num5 - num9;
		Llvm_lifetime_start_p0.Invoke(8L, &num13);
		num13 = num7 + (num3 + num11);
		Llvm_lifetime_start_p0.Invoke(8L, &num14);
		num14 = num7 + (num3 + num12);
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(num13 == num14, Expected: true))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				Llvm_lifetime_start_p0.Invoke(8L, &num16);
				num16 = Cpp_bit_cast_unsigned_long_double.Invoke(&num13) - num8;
				num15 = Cpp_bit_cast_double_unsigned_long.Invoke(&num16);
				Optional_double_Constructor_3qcik5.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq, &num15);
				Llvm_lifetime_end_p0.Invoke(8L, &num16);
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
			}
			else
			{
				Optional_double_Constructor_tpurt2.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			return *(Struct_8myw6y*)(&llvm_libc_20_1_2_cpp_optional_vhbvq.Storage);
		}
	}
}
