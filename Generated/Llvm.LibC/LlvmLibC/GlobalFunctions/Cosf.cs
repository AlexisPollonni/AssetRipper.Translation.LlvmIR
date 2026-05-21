using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cosf
{
	[MangledName("cosf")]
	[DemangledName("cosf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		double num2 = 0.0;
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double x = 0.0;
		double x2 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, anon_izyfb.Val);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			if (Details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, Expected: false))
			{
				result = (float)Fputil_multiply_add_double.Invoke(num2, -2.980232238769531E-08, 1.0);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = ExceptValues_float_6ul_lookup.Invoke(X_bits: num, This: Llvm_libc_20_1_2_COSF_EXCEPTS.Pointer);
				*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi.Storage) = storage;
				int num5;
				if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi), Expected: false))
				{
					result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
					num5 = 1;
				}
				else
				{
					num5 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
				switch (num5)
				{
				case 0:
					if (Details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, Expected: false))
					{
						if (num == 2139095040)
						{
							Fputil_set_errno_if_required.Invoke(33);
							Fputil_raise_except_if_required.Invoke(1);
						}
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb2.Val, 0);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = double.NaN;
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = double.NaN;
						Llvm_lifetime_start_p0.Invoke(8L, &x);
						x = double.NaN;
						Llvm_lifetime_start_p0.Invoke(8L, &x2);
						x2 = double.NaN;
						Llvm_libc_20_1_2_sincosf_eval.Invoke(num2, num, &num3, &num4, &x, &x2);
						result = (float)Fputil_multiply_add_double.Invoke(x, 0.0 - num3, Fputil_multiply_add_double.Invoke(x2, num4, num4));
						Llvm_lifetime_end_p0.Invoke(8L, &x2);
						Llvm_lifetime_end_p0.Invoke(8L, &x);
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
						Llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					break;
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
