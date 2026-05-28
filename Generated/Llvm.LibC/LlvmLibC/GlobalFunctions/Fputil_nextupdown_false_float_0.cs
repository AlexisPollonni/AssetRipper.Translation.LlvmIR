using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextupdown_false_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb0EfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::nextupdown<false, float, 0>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm = default(Fputil_internal_FPRepImpl_vhj4tm);
		Fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(Fputil_internal_FPRepImpl_vhj4tm);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm3 = default(Fputil_internal_FPRepImpl_vhj4tm);
		Fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm4 = default(Fputil_internal_FPRepImpl_vhj4tm);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		Llvm_memset_p0_i64.Invoke(&anon_izyfb, 0, 1L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			bool num = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			int num2;
			if (num)
			{
				num2 = 1;
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm, &fputil_FPBits_5nkvcs, 4L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb2.Val);
				fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				if (Internal_Equals_wuhucm.Invoke(fputil_internal_FPRepImpl_vhj4tm.FPRepSem.field_0.field_0, fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0))
				{
					num2 = 1;
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm3, &fputil_FPBits_5nkvcs, 4L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm4, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
					num2 = (Internal_Equals_wuhucm.Invoke(fputil_internal_FPRepImpl_vhj4tm3.FPRepSem.field_0.field_0, fputil_internal_FPRepImpl_vhj4tm4.FPRepSem.field_0.field_0) ? 1 : 0);
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			float result;
			if (num2 != 0)
			{
				result = X;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(X, 0f))
				{
					anon_izyfb4.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, &anon_izyfb, 1L, isVolatile: false);
					if (Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs4, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) + 1);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) - 1);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb6.Val);
					fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				}
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			return result;
		}
	}
}
