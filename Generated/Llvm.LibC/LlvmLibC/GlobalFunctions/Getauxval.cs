using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getauxval
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<long, long>)(&Invoke));

	[MangledName("getauxval")]
	[DemangledName("getauxval")]
	public unsafe static long Invoke([MangledName("id")] long Id)
	{
		long result = 0L;
		Llvm_libc_20_1_2_AuxvErrnoGuard llvm_libc_20_1_2_AuxvErrnoGuard = default(Llvm_libc_20_1_2_AuxvErrnoGuard);
		Anon_5uk363 anon_5uk = default(Anon_5uk363);
		Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_libc_20_1_2_AuxEntry llvm_libc_20_1_2_AuxEntry = default(Llvm_libc_20_1_2_AuxEntry);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_AuxvErrnoGuard);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_AuxvErrnoGuard) = -1431655766;
			((sbyte*)(&llvm_libc_20_1_2_AuxvErrnoGuard))[4] = -86;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_AuxvErrnoGuard) + 5;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			AuxvErrnoGuard_Constructor.Invoke(&llvm_libc_20_1_2_AuxvErrnoGuard);
			Llvm_lifetime_start_p0.Invoke(8L, &anon_5uk);
			*(IntPtr*)(&anon_5uk) = unchecked((nint)(-6148914691236517206L));
			anon_5uk.field_0 = &llvm_libc_20_1_2_AuxvErrnoGuard;
			if (Llvm_libc_20_1_2_app.Pointer != null)
			{
				result = _0_Invoke_qwsr2x.Invoke(&anon_5uk, Llvm_libc_20_1_2_app.Pointer->Auxv_ptr, Id);
			}
			else
			{
				Llvm_libc_20_1_2_callonce.Invoke(Llvm_libc_20_1_2_getauxval_impl_unsigned_long_once_flag.Pointer, Llvm_libc_20_1_2_initialize_auxv_once.__pointer);
				if (Llvm_libc_20_1_2_auxv.Value == null)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
					*(int*)(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt) = -1431655766;
					AuxvFdGuard_Constructor.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
					if (AuxvFdGuard_valid.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt))
					{
						int num4;
						do
						{
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_AuxEntry);
							*(long*)(&llvm_libc_20_1_2_AuxEntry) = -6148914691236517206L;
							((long*)(&llvm_libc_20_1_2_AuxEntry))[1] = -6148914691236517206L;
							Struct_fiz2nb struct_fiz2nb = Llvm_libc_20_1_2_read_entry.Invoke(AuxvFdGuard_get.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt));
							Llvm_libc_20_1_2_AuxEntry* num = &llvm_libc_20_1_2_AuxEntry;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num = struct_fiz2nb2.field_0;
							byte* num2 = (byte*)(&llvm_libc_20_1_2_AuxEntry) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num2 = struct_fiz2nb3.field_1;
							int num3;
							if (llvm_libc_20_1_2_AuxEntry.Tv_sec == 0L)
							{
								num3 = 3;
							}
							else if (llvm_libc_20_1_2_AuxEntry.Tv_sec == Id)
							{
								result = llvm_libc_20_1_2_AuxEntry.Tv_nsec;
								num3 = 1;
							}
							else
							{
								num3 = 0;
							}
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_AuxEntry);
							num4 = num3;
						}
						while (num4 == 0);
						if (num4 != 3)
						{
							goto IL_0201;
						}
					}
					AuxvErrnoGuard_mark_failure.Invoke(&llvm_libc_20_1_2_AuxvErrnoGuard);
					result = 0L;
					goto IL_0201;
				}
				result = _0_Invoke_qwsr2x.Invoke(&anon_5uk, Llvm_libc_20_1_2_auxv.Value, Id);
			}
			goto IL_021a;
		}
		IL_021a:
		Llvm_lifetime_end_p0.Invoke(8L, &anon_5uk);
		AuxvErrnoGuard_Destructor.Invoke(&llvm_libc_20_1_2_AuxvErrnoGuard);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_AuxvErrnoGuard);
		return result;
		IL_0201:
		AuxvFdGuard_Destructor.Invoke(&llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		goto IL_021a;
	}
}
