using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextupdown_true_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb1EDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::nextupdown<true, _Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh10 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh11 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh12 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh13 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		unchecked
		{
			*(sbyte*)(&anon_izyfb8) = 1;
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			bool num = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh10, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &anon_izyfb8, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb9.val);
				fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh11, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
				if (internal_Equals_9g7dhj.Invoke(fputil_internal_FPRepImpl_7z3gh10.FPRepSem.FPStorage.field_0, fputil_internal_FPRepImpl_7z3gh11.FPRepSem.FPStorage.field_0))
				{
					num2 = -1;
				}
				else
				{
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh12, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, &anon_izyfb8, 1L, isVolatile: false);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb10.val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh13, &fputil_FPBits_2fahva4, 2L, isVolatile: false);
					num2 = (internal_Equals_9g7dhj.Invoke(fputil_internal_FPRepImpl_7z3gh12.FPRepSem.FPStorage.field_0, fputil_internal_FPRepImpl_7z3gh13.FPRepSem.FPStorage.field_0) ? 1 : 0);
				}
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			Half result;
			if (num2 != 0)
			{
				result = x;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(x, default(Half)))
				{
					anon_izyfb11.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, &anon_izyfb8, 1L, isVolatile: false);
					if (Equals_fy8fvt.Invoke(anon_izyfb11.val, anon_izyfb12.val))
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva5, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) + 1));
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva5, 2L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva6, (short)checked(unchecked((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) - 1));
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva6, 2L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, &anon_izyfb8, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_min_subnormal.Invoke(anon_izyfb13.val);
					fputil_FPBits_2fahva7.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva7, 2L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			return result;
		}
	}
}
