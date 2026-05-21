using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextupdown_false_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb0EfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::nextupdown<false, float, 0>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm3 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm4 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm5 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		llvm_memset_p0_i64.Invoke(&anon_izyfb8, 0, 1L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			bool num = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb9.val);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm3, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
				if (internal_Equals_wuhucm.Invoke(fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0, fputil_internal_FPRepImpl_vhj4tm3.FPRepSem.field_0.field_0))
				{
					num2 = -1;
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm4, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb10.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm5, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
					num2 = (internal_Equals_wuhucm.Invoke(fputil_internal_FPRepImpl_vhj4tm4.FPRepSem.field_0.field_0, fputil_internal_FPRepImpl_vhj4tm5.FPRepSem.field_0.field_0) ? 1 : 0);
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			float result;
			if (num2 != 0)
			{
				result = x;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(x, 0f))
				{
					anon_izyfb11.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb8, 1L, isVolatile: false);
					if (Equals_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val))
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) + 1);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs6, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) - 1);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb13.val);
					fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs7, 4L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				}
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
