using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tanf
{
	[MangledName("tanf")]
	[DemangledName("tanf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num = 0;
		double num2 = 0.0;
		double x = 0.0;
		double num3 = 0.0;
		float num4 = 0f;
		float num5 = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Cpp_optional_xmxtsi cpp_optional_xmxtsi = default(Cpp_optional_xmxtsi);
		double xd = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) >>> 31 != 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) & 0x7FFFFFFF;
			if (Details_expects_bool_condition_bool.Invoke((uint)num <= 1036586971u, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = X;
				if (Details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, Expected: false))
				{
					result = ((!Details_expects_bool_condition_bool.Invoke(num == 0, Expected: false)) ? ((float)Fputil_multiply_add_double.Invoke(num2, 2.980232238769531E-08, num2)) : X);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num2 * num2;
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = Fputil_polyeval_double_double_double_double_double.Invoke(x, 1.0, 0.33333333332780246, 0.1333333388397673, 0.05396654162717383, 0.022079624737833755);
					result = (float)(num2 * num3);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			else if (Details_expects_bool_condition_bool.Invoke(num == 1066016610, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = InstructionHelper.Select((b & 1) == 1, -1f, 1f);
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = 1.8670952f;
				num5 = Fputil_multiply_add_float.Invoke(num4, num5, num4 * 6.3329935E-08f);
				result = num5;
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num > 1297535828u, Expected: false))
				{
					if (Details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, Expected: false))
					{
						if (num == 2139095040)
						{
							Fputil_set_errno_if_required.Invoke(33);
							Fputil_raise_except_if_required.Invoke(1);
						}
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
						fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = X + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
						goto IL_0524;
					}
					Llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi);
					sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi);
					*(float*)ptr = float.NaN;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = ExceptValues_float_6ul_lookup_odd.Invoke(X_abs: num, Sign: (b & 1) == 1, This: TANF_EXCEPTS.Pointer);
					*(long*)(&cpp_optional_xmxtsi.Storage) = storage;
					int num8;
					if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&cpp_optional_xmxtsi), Expected: false))
					{
						result = *(float*)Optional_float_value.Invoke(&cpp_optional_xmxtsi);
						num8 = 1;
					}
					else
					{
						num8 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi);
					switch (num8)
					{
					case 0:
						break;
					default:
						goto IL_0524;
					}
				}
				Llvm_lifetime_start_p0.Invoke(8L, &xd);
				xd = X;
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = double.NaN;
				Sincosf_eval.Invoke(xd, num, &num6, &num7, &x2, &x3);
				result = (float)(Fputil_multiply_add_double.Invoke(x2, num7, Fputil_multiply_add_double.Invoke(x3, num6, num6)) / Fputil_multiply_add_double.Invoke(x2, 0.0 - num6, Fputil_multiply_add_double.Invoke(x3, num7, num7)));
				Llvm_lifetime_end_p0.Invoke(8L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &xd);
			}
			goto IL_0524;
		}
		IL_0524:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		return result;
	}
}
