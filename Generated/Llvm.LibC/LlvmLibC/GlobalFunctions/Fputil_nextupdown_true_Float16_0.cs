using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextupdown_true_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb1EDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::nextupdown<true, _Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh = default(Fputil_internal_FPRepImpl_7z3gh9);
		Fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh2 = default(Fputil_internal_FPRepImpl_7z3gh9);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh3 = default(Fputil_internal_FPRepImpl_7z3gh9);
		Fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh4 = default(Fputil_internal_FPRepImpl_7z3gh9);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			*(sbyte*)(&anon_izyfb) = 1;
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			bool num = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			int num2;
			if (num)
			{
				num2 = 1;
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh, &fputil_FPBits_2fahva, 2L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb2.Val);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh2, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
				if (Internal_Equals_9g7dhj.Invoke(fputil_internal_FPRepImpl_7z3gh.FPRepSem.FPStorage.field_0, fputil_internal_FPRepImpl_7z3gh2.FPRepSem.FPStorage.field_0))
				{
					num2 = 1;
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh3, &fputil_FPBits_2fahva, 2L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb3.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh4, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
					num2 = (Internal_Equals_9g7dhj.Invoke(fputil_internal_FPRepImpl_7z3gh3.FPRepSem.FPStorage.field_0, fputil_internal_FPRepImpl_7z3gh4.FPRepSem.FPStorage.field_0) ? 1 : 0);
				}
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Half result;
			if (num2 != 0)
			{
				result = X;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(X, default(Half)))
				{
					anon_izyfb4.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, &anon_izyfb, 1L, isVolatile: false);
					if (Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val))
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva4, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) + 1));
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva4, 2L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva5, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) - 1));
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva5, 2L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal.Invoke(anon_izyfb6.Val);
					fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva6, 2L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				}
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			return result;
		}
	}
}
