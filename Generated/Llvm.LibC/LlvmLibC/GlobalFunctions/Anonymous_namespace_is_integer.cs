using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_is_integer
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110is_integerEd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::is_integer(double)")]
	public unsafe static bool Invoke([MangledName("x")][NativeType("double")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = Cpp_countr_zero_unsigned_long.Invoke(num | 0x7FF0000000000000L);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 1075;
			bool result = (uint)(num2 + num3) >= 1075u;
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_110is_integerEf")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::is_integer(float)")]
	public unsafe static bool Invoke([MangledName("x")][NativeType("float")] float X)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = X;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Cpp_bit_cast_unsigned_int_float.Invoke(&num5);
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = (num & 0x7F800000) >>> 23;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = Cpp_countr_zero_unsigned_int.Invoke(num | 0x7F800000);
		Llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = 150;
		bool result = num2 + num3 >= 150;
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
