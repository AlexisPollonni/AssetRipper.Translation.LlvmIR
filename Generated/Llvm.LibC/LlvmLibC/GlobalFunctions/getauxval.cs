using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class getauxval
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<long, long>)(&Invoke));

	public unsafe static long Invoke(long id)
	{
		long result = 0L;
		AuxvErrnoGuard auxvErrnoGuard = default(AuxvErrnoGuard);
		anon_5uk363 anon_5uk364 = default(anon_5uk363);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		AuxEntry auxEntry = default(AuxEntry);
		llvm_lifetime_start_p0.Invoke(8L, &auxvErrnoGuard);
		unchecked
		{
			*(int*)(&auxvErrnoGuard) = -1431655766;
			((sbyte*)(&auxvErrnoGuard))[4] = -86;
			sbyte* ptr = (sbyte*)(&auxvErrnoGuard) + 5;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			AuxvErrnoGuard_Constructor.Invoke(&auxvErrnoGuard);
			llvm_lifetime_start_p0.Invoke(8L, &anon_5uk364);
			*(IntPtr*)(&anon_5uk364) = unchecked((nint)(-6148914691236517206L));
			anon_5uk364.field_0 = &auxvErrnoGuard;
			if (app.Pointer != null)
			{
				result = _0_Invoke_qwsr2x.Invoke(&anon_5uk364, app.Pointer->auxv_ptr, id);
			}
			else
			{
				callonce.Invoke(getauxval_impl_unsigned_long_once_flag.Pointer, initialize_auxv_once.__pointer);
				if (auxv.Value == null)
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
					*(int*)(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2) = -1431655766;
					AuxvFdGuard_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
					if (AuxvFdGuard_valid.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2))
					{
						int num4;
						do
						{
							llvm_lifetime_start_p0.Invoke(16L, &auxEntry);
							*(long*)(&auxEntry) = -6148914691236517206L;
							((long*)(&auxEntry))[1] = -6148914691236517206L;
							Struct_fiz2nb struct_fiz2nb = read_entry.Invoke(AuxvFdGuard_get.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2));
							AuxEntry* num = &auxEntry;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num = struct_fiz2nb2.field_0;
							byte* num2 = (byte*)(&auxEntry) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num2 = struct_fiz2nb3.field_1;
							int num3;
							if (auxEntry.tv_sec == 0L)
							{
								num3 = 3;
							}
							else if (auxEntry.tv_sec == id)
							{
								result = auxEntry.tv_nsec;
								num3 = 1;
							}
							else
							{
								num3 = 0;
							}
							llvm_lifetime_end_p0.Invoke(16L, &auxEntry);
							num4 = num3;
						}
						while (num4 == 0);
						if (num4 != 3)
						{
							goto IL_0201;
						}
					}
					AuxvErrnoGuard_mark_failure.Invoke(&auxvErrnoGuard);
					result = 0L;
					goto IL_0201;
				}
				result = _0_Invoke_qwsr2x.Invoke(&anon_5uk364, auxv.Value, id);
			}
			goto IL_021a;
		}
		IL_021a:
		llvm_lifetime_end_p0.Invoke(8L, &anon_5uk364);
		AuxvErrnoGuard_Destructor.Invoke(&auxvErrnoGuard);
		llvm_lifetime_end_p0.Invoke(8L, &auxvErrnoGuard);
		return result;
		IL_0201:
		AuxvFdGuard_Destructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2);
		goto IL_021a;
	}
}
