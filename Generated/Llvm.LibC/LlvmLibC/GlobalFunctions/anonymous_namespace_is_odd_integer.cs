using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class anonymous_namespace_is_odd_integer
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114is_odd_integerEd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::is_odd_integer(double)")]
	public unsafe static bool Invoke([NativeType("double")] double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = cpp_countr_zero_unsigned_long.Invoke(num | 0x7FF0000000000000L);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 1075;
			bool result = num2 + num3 == 1075;
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114is_odd_integerEf")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::is_odd_integer(float)")]
	public unsafe static bool Invoke([NativeType("float")] float x)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = x;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_bit_cast_unsigned_int_float.Invoke(&num5);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = (num & 0x7F800000) >>> 23;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = cpp_countr_zero_unsigned_int.Invoke(num | 0x7F800000);
		llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = 150;
		bool result = num2 + num3 == 150;
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
